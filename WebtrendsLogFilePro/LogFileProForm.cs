using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace WebtrendsLogFilePro
{
    public partial class LogFileProForm : Form
    {
        #region Global Variables

        // Background workers
        private BackgroundWorker extractorWorker;
        private BackgroundWorker queryParamsWorker;
        private BackgroundWorker fileStatsWorker;
        private BackgroundWorker logFileWorker;
        
        // Timing
        private Timer timer;
        private Stopwatch stopWatch;

        // Field Nodes
        private List<string> globalQueryParams;
        private FieldHeaderNode queryParamNode { get { return treeView_fields.Nodes[0].Nodes[7] as FieldHeaderNode; } }
        private FieldHeaderNode geoParamNode { get { return treeView_fields.Nodes[0].Nodes[14] as FieldHeaderNode; } }

        // UI Numerical values
        private int totalRows = 0;
        private int parsedLines = 0;
        private int tasksRunning = 0;
        private long fileSize = 0;

        // Query Param Scan Modes
        public enum FindQueryParamsSpeed { Single, Quick, Full };

        // Filepaths
        private string validLogFile;
        private string outputFile;
        private string outputDir;

        // Parse Functions
        private Func<string, string> decode;
        private Func<string[], string> joinQueryParams;
        private Func<string[], string> joinParsedLine;

        // Log File Delimiter - Just tab for now
        private string delimiter = "\t";

        #endregion

        #region Main Class

        public LogFileProForm()
        {
            // Init UI Elements
            InitializeComponent();
            InitOutputTypes();
            InitFileStats();
            InitFields();

            // Set global values based on UI
            SetDecoder();
            SetJoinedLogic();

            // Start with Output UI disabled
            SetOutputUIElements(false);
        }

        #endregion

        #region UI Init Functions

        /// <summary>
        /// Set the parsed file output types.
        /// </summary>
        private void InitOutputTypes()
        {
            cmb_outputFormat.Items.Add(".tab (Tab Delimited)");
            cmb_outputFormat.SelectedIndex = 0;
        }

        /// <summary>
        /// Reset the UI file stat values.
        /// </summary>
        private void InitFileStats()
        {
            lbl_TotalRowsValue.Text = "0";
            lbl_FileSizeValue.Text = "0";
            lbl_QueryParamsValue.Text = "0";
            lbl_TimeElapsedValue.Text = "00:00:00";
            lbl_CompletionValue.Text = "0%";
            lbl_ParsedRowsValue.Text = "0";
        }

        /// <summary>
        /// Set up UI fields with known log file values. Query params are added later.
        /// </summary>
        private void InitFields()
        {
            // Create global fields objects.
            // Standard --> date time c-ip cs-username cs-host cs-method cs-uri-stem sc-status sc-bytes cs-version cs(User-Agent) cs(Cookie) cs(Referer) dcs-dns origin-id dcs-id
            // Query Parameters --> [Perform Initial Scan]
            // Geo --> ar cc ci cn co cs dm dmc dms nt rc rs tz

            // If calling while already running, empty fields first.
            treeView_fields.Nodes.Clear();

            treeView_fields.Nodes.Add("All Fields");

            treeView_fields.Nodes[0].Nodes.Add(new FieldHeaderNode("date", "Date"));
            treeView_fields.Nodes[0].Nodes.Add(new FieldHeaderNode("time", "Time"));
            treeView_fields.Nodes[0].Nodes.Add(new FieldHeaderNode("c-ip", "Client IP"));
            treeView_fields.Nodes[0].Nodes.Add(new FieldHeaderNode("cs-username", "Auth Username"));
            treeView_fields.Nodes[0].Nodes.Add(new FieldHeaderNode("cs-host", "Domain"));
            treeView_fields.Nodes[0].Nodes.Add(new FieldHeaderNode("cs-method", "Client Method"));
            treeView_fields.Nodes[0].Nodes.Add(new FieldHeaderNode("cs-uri-stem", "URI Stem"));

            FieldHeaderNode queryParams = new FieldHeaderNode("cs-uri-query", "Query Parameters");

            treeView_fields.Nodes[0].Nodes.Add(queryParams);
            treeView_fields.Nodes[0].Nodes.Add(new FieldHeaderNode("sc-status", "SC Status"));
            treeView_fields.Nodes[0].Nodes.Add(new FieldHeaderNode("sc-bytes", "SC Bytes"));
            treeView_fields.Nodes[0].Nodes.Add(new FieldHeaderNode("cs-version", "Protocol Version"));
            treeView_fields.Nodes[0].Nodes.Add(new FieldHeaderNode("cs(User-Agent)", "User Agent"));
            treeView_fields.Nodes[0].Nodes.Add(new FieldHeaderNode("cs(Cookie)", "User Cookie"));
            treeView_fields.Nodes[0].Nodes.Add(new FieldHeaderNode("cs(Referrer)", "Referrer"));

            FieldHeaderNode geoParams = new FieldHeaderNode("dcs-geo", "Geo");
            string[] geoVals = new string[13] { "ar", "cc", "ci", "cn", "co", "cs", "dm", "dmc", "dms", "nt", "rc", "rs", "tz" };
            foreach (string val in geoVals) {
                geoParams.Nodes.Add(new TreeNode(val));
            }

            treeView_fields.Nodes[0].Nodes.Add(geoParams);
            treeView_fields.Nodes[0].Nodes.Add(new FieldHeaderNode("dcs-dns", "DNS"));
            treeView_fields.Nodes[0].Nodes.Add(new FieldHeaderNode("origin-id", "Origin ID"));
            treeView_fields.Nodes[0].Nodes.Add(new FieldHeaderNode("dcs-id", "DataSource ID"));

            // TreeView is "TriStateTreeView", to allow three states. Need to define type here. 
            treeView_fields.TriStateStyleProperty = TriStateTreeView.TriStateStyles.Installer;

            // Ensure it is expanded when initialised.
            treeView_fields.Nodes[0].Expand();
        }

        /// <summary>
        /// Resets certain UI components for a new log file.
        /// </summary>
        private void ResetUIForNewFile()
        {
            InitFileStats();
            queryParamNode.Nodes.Clear();
            SetOutputDirectory(Path.GetDirectoryName(validLogFile));
            SetOutputUIElements(false);
            OpenFileButtonsVisible(false);
        }

        /// <summary>
        /// Sets the output directory UI value and global object.
        /// TODO: Perhaps look into proper data bindings.
        /// </summary>
        /// <param name="outputDir">The output directory value.</param>
        private void SetOutputDirectory(string outputDir)
        {
            txt_outputDir.Text = outputDir;
            this.outputDir = outputDir;
        }

        /// <summary>
        /// Show/Hide the open file buttons depending if parsing job has completed.
        /// </summary>
        /// <param name="visible"></param>
        private void OpenFileButtonsVisible(bool visible)
        {
            lbl_openFile.Visible = visible;
            btn_Excel.Visible = visible;
            btn_Explorer.Visible = visible;
        }

        /// <summary>
        /// Enabled/Disable Output UI elements. Called when valid log file submitted. 
        /// </summary>
        /// <param name="enabled"></param>
        private void SetOutputUIElements(bool enabled)
        {
            treeView_fields.Enabled = enabled;
            treeView_fields.BackColor = enabled ? System.Drawing.Color.White : System.Drawing.SystemColors.Control;

            grp_OutputConfig.Enabled = enabled;
            grp_Statistics.Enabled = enabled;
            grp_AddQueryParams.Enabled = enabled;
            grp_Statistics.Enabled = enabled;
            grp_ParseProgress.Enabled = enabled;
            btn_start.Enabled = enabled;

            // Hide the open file buttons if we're disabling the output UI.
            if (!enabled) {
                OpenFileButtonsVisible(enabled);
            }
        }

        #endregion

        #region UI Event Listeners

        private void btn_GzFileDirectory_Click(object sender, EventArgs e)
        {
            LocateGzDirectory();
        }

        private void btn_SevenZip_Click(object sender, EventArgs e)
        {
            LocateSevenZipFile();
        }

        private void btn_SingleLogFile_Click(object sender, EventArgs e)
        {
            LocateSingleLogFile();
        }

        private void btn_ExtractLogFiles_Click(object sender, EventArgs e)
        {
            ExtractLogFilesAndMerge();
        }

        private void btn_SubmitSingleLogFile_Click(object sender, EventArgs e)
        {
            SubmitLogFile();
        }

        private void btn_AddQueryParams_Click(object sender, EventArgs e)
        {
            AddQueryParamsFromUI();
        }

        private void txt_AddQueryParams_KeyDown(object sender, KeyEventArgs e)
        {
            // Enter while on the fields form selects/deselects the node.
            if (e.KeyCode == Keys.Enter) {
                AddQueryParamsFromUI();
            }            
        }

        private void btn_QuickScan_Click(object sender, EventArgs e)
        {
            FindAndSetQueryParamFields(FindQueryParamsSpeed.Quick, validLogFile);
        }

        private void btn_FullScan_Click(object sender, EventArgs e)
        {
            FindAndSetQueryParamFields(FindQueryParamsSpeed.Full, validLogFile);
        }

        private void btn_Excel_Click(object sender, EventArgs e)
        {
            OpenLogFileWithExcel();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            StartParsingProcess();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        #region Button Functions

        #region Input Config Functions

        /// <summary>
        /// Show folder dialogue for GZ file directory.
        /// </summary>
        private void LocateGzDirectory()
        {
            LocateAndUpdateUI(ShowOpenFolderDialog, txt_GzFileDirectory);
        }

        /// <summary>
        /// Show file dialogue for 7z.exe file.
        /// </summary>
        private void LocateSevenZipFile()
        {
            LocateAndUpdateUI(ShowOpenFileDialog, txt_SevenZipFile, @"exe files (*.exe)|*.exe");
        }

        /// <summary>
        /// Show file dialogue for single log file.
        /// </summary>
        private void LocateSingleLogFile()
        {
            LocateAndUpdateUI(ShowOpenFileDialog, txt_SingleLogFile, @"log files (*.log)|*.log|txt files (*.txt)|*.txt");
        }

        /// <summary>
        /// Given an open dialogue function, and a textbox, update that text box 
        /// using the logic within the provided function and filter values.
        /// </summary>
        /// <param name="openDialogue">The function which shows dialogue and validates selected value.</param>
        /// <param name="textBox">The textbox element from the UI we want to update.</param>
        /// <param name="filter">Only show these files in the file select dialogue.</param>
        private void LocateAndUpdateUI(Func<string, string, string> openDialogue, TextBox textBox, string filter = "*.*")
        {
            var startVal = textBox.Text;
            var newVal = openDialogue(startVal, filter);

            if (string.IsNullOrEmpty(newVal)) {
                return;
            } else {
                textBox.Text = newVal;
            }
        }

        /// <summary>
        /// Initiate the file extractor worker, first validating the fields from the UI.
        /// </summary>
        private void ExtractLogFilesAndMerge()
        {
            // Get folder path from the text box.
            string gzFolderPath = txt_GzFileDirectory.Text;
            if (string.IsNullOrWhiteSpace(gzFolderPath) || !Directory.Exists(gzFolderPath)) {
                ShowErrorBox("Please enter a valid Gz Folder Directory!");
                return;
            }

            // Confirm it contains gz files
            string[] gzFiles = Directory.GetFiles(gzFolderPath, "*.gz", SearchOption.TopDirectoryOnly);
            if (gzFiles.Length == 0) {
                ShowErrorBox("Folder contains no .gz files!");
                return;
            }

            // Confirm 7zip.exe exists
            string sZip = txt_SevenZipFile.Text;
            if (string.IsNullOrWhiteSpace(sZip) || !File.Exists(sZip)) {
                ShowErrorBox("Cannot find 7z.exe file!");
                return;
            }

            extractorWorker = new BackgroundWorker();
            extractorWorker.DoWork += (obj, e) => ExecuteExtractorDoWork(sZip, gzFolderPath);
            extractorWorker.RunWorkerCompleted += (obj, e) => ExtractorWorkerCompleted(e, gzFolderPath);

            StartWaiting(true);

            extractorWorker.RunWorkerAsync();
        }

        /// <summary>
        /// Perform several tasks to extract, merge, delete to create a single log file to be used.
        /// </summary>
        /// <param name="sZip">7z.exe filepath - TODO: Global param?</param>
        /// <param name="gzFolderPath">GZ folder location - TODO: Global param?</param>
        private void ExecuteExtractorDoWork(string sZip, string gzFolderPath)
        {
            // Start 7zip Extraction Process
            ProcessStartInfo fileExtraction = new ProcessStartInfo {
                FileName = sZip,
                Arguments = "e *.gz -y",
                WorkingDirectory = gzFolderPath,
                WindowStyle = ProcessWindowStyle.Hidden,
            };
            ExecuteSystemProcess(fileExtraction);

            // Combine all log files into one temp file
            ProcessStartInfo combineLogFiles = new ProcessStartInfo {
                FileName = "cmd.exe",
                Arguments = string.Format("/c copy {0} {1} /y", "*.log", "slf.temp"),
                WorkingDirectory = gzFolderPath,
                WindowStyle = ProcessWindowStyle.Hidden
            };
            ExecuteSystemProcess(combineLogFiles);

            // Remove all log files
            ProcessStartInfo removeLogFiles = new ProcessStartInfo {
                FileName = "cmd.exe",
                Arguments = string.Format("/c del *.log"),
                WorkingDirectory = gzFolderPath,
                WindowStyle = ProcessWindowStyle.Hidden
            };
            ExecuteSystemProcess(removeLogFiles);

            // Rename temp file to single-log-file.log
            ProcessStartInfo renameTempFile = new ProcessStartInfo {
                FileName = "cmd.exe",
                Arguments = string.Format("/c ren slf.temp single-log-file.log"),
                WorkingDirectory = gzFolderPath,
                WindowStyle = ProcessWindowStyle.Hidden
            };
            ExecuteSystemProcess(renameTempFile);
        }

        /// <summary>
        /// Extraction worker has finished/stopped. Perform required clean up steps.
        /// </summary>
        /// <param name="e"></param>
        /// <param name="gzFolderPath"></param>
        private void ExtractorWorkerCompleted(RunWorkerCompletedEventArgs e, string gzFolderPath)
        {
            if (e.Error != null) {
                ShowErrorBox("Failed to extract .gz files!" + Environment.NewLine + e.Error.Message);
            } else if (e.Cancelled) {
                // Cancelled
            } else {
                // Success
                // Set the newly created file as the Single Log File text.
                txt_SingleLogFile.Text = gzFolderPath + "\\single-log-file.log";
            }

            StartWaiting(false);

            extractorWorker.Dispose();
        }

        private void SubmitLogFile()
        {
            // Grab single log file and check it exists
            string singleLogFile = txt_SingleLogFile.Text;
            if (string.IsNullOrWhiteSpace(singleLogFile) || !File.Exists(singleLogFile)) {
                ShowErrorBox("Please enter valid log file!");
                return;
            }

            // Check it is a valid log file
            if (!IsValidLogFile(singleLogFile)) {
                ShowErrorBox("Please enter valid log file!");
                return;
            }

            validLogFile = singleLogFile;

            // Log file is valid so we can enabled UI elements. 
            UpdateUIForValidLogFile();
        }

        private bool IsValidLogFile(string filePath)
        {
            var result = false;

            // A valid sequece of headers for a WT log file.
            var validHeadersString =
                "#Fields: date time c-ip cs-username cs-host " +
                "cs-method cs-uri-stem cs-uri-query sc-status " +
                "sc-bytes cs-version cs(User-Agent) cs(Cookie)" +
                " cs(Referer) dcs-geo dcs-dns origin-id dcs-id";
            var validHeaders = validHeadersString.Split(' ');


            // Process the first line only which contains the headers.
            foreach (var line in File.ReadLines(filePath, Encoding.UTF8)) {
                // First line will contain some known headers.
                var headers = line.Split(' ');

                // First check headers are same length.
                result = headers.Length == validHeaders.Length;

                // Loop through headers making sure all is as expected.
                for (var i = 0; i < validHeaders.Length && result; i++) {
                    result &= headers[i] == validHeaders[i];
                }

                break;
            }

            return result;
        }

        private void UpdateUIForValidLogFile()
        {
            ResetUIForNewFile();

            // Load fields
            FindAndSetQueryParamFields(FindQueryParamsSpeed.Single, validLogFile);

            // Set File Stats
            SetFileStats(validLogFile);
        }

        #region File Stats Worker

        private void SetFileStats(string logFile)
        {
            fileStatsWorker = new BackgroundWorker();
            fileStatsWorker.DoWork += (obj, e) => FileStatsDoWork(logFile);
            fileStatsWorker.RunWorkerCompleted += FileStatsWorkerCompleted;

            StartWaiting(true);

            fileStatsWorker.RunWorkerAsync();
        }

        private void FileStatsWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null) {
                ShowErrorBox("Error while retreiving log file stats!" + Environment.NewLine + e.Error.Message);
            } else if (e.Cancelled) {
                // Cancelled
            } else {
                // Success
            }

            StartWaiting(false);

            lbl_TotalRowsValue.Text = totalRows.ToString();
            lbl_FileSizeValue.Text = (fileSize / 1024 / 1024).ToString();

            fileStatsWorker.Dispose();

            // Enable UI Elements
            SetOutputUIElements(true);
        }

        private void FileStatsDoWork(string logFile)
        {
            totalRows = File.ReadLines(logFile).Count();
            fileSize = new FileInfo(logFile).Length;
        }

        #endregion

        #endregion

        #region Query Param Functions

        public List<string> FindQueryParams(FindQueryParamsSpeed method, string logFile)
        { 
            var result = new List<string>();

            var queryParamsHash = new HashSet<string>();

            switch (method) {                
                case FindQueryParamsSpeed.Single:

                    File.ReadLines(logFile).Take(2).ToList().ForEach(x => queryParamsHash.UnionWith(ParseLineForQueryParamKeys(x)));

                    break;
                case FindQueryParamsSpeed.Quick:
                    int totalRows = int.Parse(lbl_TotalRowsValue.Text);
                    int fivePercent = totalRows / 20;
                    int linesToParse = (fivePercent > 0) ? fivePercent : 2;

                    File.ReadLines(logFile).Take(linesToParse).ToList().ForEach(x => queryParamsHash.UnionWith(ParseLineForQueryParamKeys(x)));

                    break;
                case FindQueryParamsSpeed.Full:

                    Parallel.ForEach(File.ReadLines(logFile), (line, _, lineNumber) => {
                        queryParamsHash.UnionWith(ParseLineForQueryParamKeys(line));
                    });

                    break;
            }

            result = queryParamsHash.Where(s => !string.IsNullOrWhiteSpace(s)).ToList();
            result.Sort();

            return result;
        }

        public List<string> ParseLineForQueryParamKeys(string logFileLine)
        {
            var result = new List<string>();            

            if(logFileLine[0] != '#') {
                string[] logFileSplit = logFileLine.Split(' ');
                if (logFileSplit.Length >= 7) {
                    string queryParamsBlock = logFileSplit[7];
                    result = HttpUtility.ParseQueryString(queryParamsBlock).AllKeys.ToList();
                }
            }

            return result;
        }

        public void FindAndSetQueryParamFields(FindQueryParamsSpeed speed, string logFile)
        {
            queryParamsWorker = new BackgroundWorker();
            queryParamsWorker.DoWork += (obj, e) => QueryParamsWorkerDoWork(speed, logFile);
            queryParamsWorker.RunWorkerCompleted += QueryParamsWorkerCompleted;

            StartWaiting(true);

            queryParamsWorker.RunWorkerAsync();
        }

        private void QueryParamsWorkerDoWork(FindQueryParamsSpeed speed, string logFile)
        {
            AddToGlobalQueryParams(FindQueryParams(speed, logFile));
        }

        private void QueryParamsWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null) {
                ShowErrorBox("Error when finding log files: " + e.Error.Message);
            } else if (e.Cancelled) {
                // Cancelled
            } else {
                // Success
                RefreshQueryParamsUI();
            }

            StartWaiting(false);
        }

        private void RefreshQueryParamsUI()
        {
            // Clear existing nodes.
            queryParamNode.Nodes.Clear();

            // Add new nodes
            globalQueryParams.ForEach(val => queryParamNode.Nodes.Add(val));

            // Refresh UI if needed.
            if (queryParamNode.IsExpanded) {
                queryParamNode.Collapse();
                queryParamNode.Expand();
            }
            
            // List has been reset, so selections should be cleared also.
            queryParamNode.Checked = false;

            lbl_QueryParamsValue.Text = globalQueryParams.Count.ToString();
        }

        private void AddToGlobalQueryParams(List<string> newParams)
        {
            // Get existing nodes
            List<string> currentQueryParams =
                queryParamNode.Nodes.Cast<TreeNode>().Select(x => x.Text).ToList();

            // Combine new ones with exising ones.
            newParams.AddRange(currentQueryParams);

            // Sort list (Maybe it should be sorted already?)
            newParams.Sort();

            // There will be no duplicates.
            globalQueryParams = new List<string>();
            globalQueryParams.AddRange(newParams.Distinct());
        }

        private void AddQueryParamsFromUI()
        {
            string queryParams = txt_AddQueryParams.Text;
            if(!string.IsNullOrWhiteSpace(queryParams)) {
                List<string> queryParamArray = new List<string>(queryParams.Split(',')
                    .Where(s => !string.IsNullOrWhiteSpace(s.Trim()))
                    .Distinct()
                    .Select(x => x.Trim()));
                AddToGlobalQueryParams(queryParamArray);
            }

            RefreshQueryParamsUI();
            txt_AddQueryParams.Text = "";
        }

        #endregion

        #region Core Processing Functions

        private void StartParsingProcess()
        {
            // Gather fields. Validate.
            var selectedNodes = treeView_fields.Nodes[0].Nodes.Cast<TreeNode>()
                .Where(x => x.StateImageIndex > 0)
                .Select(y => y as FieldHeaderNode)
                .ToArray();

            if(selectedNodes.Length == 0) {
                ShowErrorBox("No Fields Selected!");
                return;
            }

            if(!File.Exists(validLogFile)) {
                ShowErrorBox("Log File Doesn't Exist!");
                return;
            }

            if(string.IsNullOrEmpty(txt_OutputFilename.Text.Trim())) {
                ShowErrorBox("Invalid Output Filename!");
                return;
            }

            if(!Directory.Exists(txt_outputDir.Text)) {
                ShowErrorBox("Invalid Output Directory!");
                return;
            }

            int[] selectedNodeIndexes = selectedNodes.Select(x => x.Index).ToArray();

            string[] selectedNodeHeaders = selectedNodes.Select(x => x.displayName).ToArray();

            string[] selectedQueryParameters = queryParamNode.Nodes.Cast<TreeNode>()
                .Where(x => x.Checked)
                .Select(y => y.Text)
                .ToArray();

            string[] selectedGeoParameters = geoParamNode.Nodes.Cast<TreeNode>()
                .Where(x => x.Checked)
                .Select(y => y.Text)
                .ToArray();

            var selectedTypeIndex = cmb_outputFormat.SelectedIndex;

            InitLogFileWorker(selectedTypeIndex, selectedNodeIndexes, selectedNodeHeaders, selectedQueryParameters, selectedGeoParameters, validLogFile);

            InitProgressBox();

            StartWaiting(true);

            logFileWorker.RunWorkerAsync();
        }

        private void InitProgressBox()
        {
            lbl_ParsedRowsValue.Text = "0";
            lbl_TimeElapsedValue.Text = "00:00:00";
            lbl_CompletionValue.Text = "0%";

            timer = new Timer();
            timer.Interval = (50); // 0.05 second
            timer.Tick += new EventHandler(Timer_Tick);

            stopWatch = new Stopwatch();

            stopWatch.Start();
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            lbl_ParsedRowsValue.Text = parsedLines.ToString();
            lbl_CompletionValue.Text = ((double)parsedLines / totalRows).ToString("#.##%");
            lbl_TimeElapsedValue.Text = stopWatch.Elapsed.ToString("hh\\:mm\\:ss");
        }

        private void InitLogFileWorker(int outputType, int[] selectedNodeIndexes, string[] selectedNodeHeaders, string[] selectedQueryParameters, string[] selectedGeoParameters, string logFile)
        {
            logFileWorker = new BackgroundWorker();

            switch (outputType) {
                case 0:
                    logFileWorker.DoWork += (obj, e) => CreateTABFile(obj, selectedNodeIndexes, selectedNodeHeaders, selectedQueryParameters, selectedGeoParameters, validLogFile);
                    break;
                case 1:
                    logFileWorker.DoWork += (obj, e) => CreateJSONFile(obj, selectedNodeIndexes, selectedNodeHeaders, selectedQueryParameters, selectedGeoParameters, validLogFile);
                    break;
            }

            logFileWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(logFileWorkerCompleted);
        }

        private void logFileWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null) {
                ShowErrorBox("Error Occured while Parsing File. Reached Line " + parsedLines + "\n\n" + e.Error.Message);
            } else if (e.Cancelled) {
                // Cancelled
            } else {
                // Success
                lbl_ParsedRowsValue.Text = parsedLines.ToString();
                lbl_CompletionValue.Text = "100%";
                OpenFileButtonsVisible(true);
            }

            stopWatch.Stop();
            timer.Stop();
            
            StartWaiting(false);
        }

        private void CreateTABFile(object sender, int[] selectedNodeIndexes, string[] selectedNodeHeaders, string[] selectedQueryParameters, string[] selectedGeoParameters, string logFile)
        {
            BackgroundWorker worker = sender as BackgroundWorker;            

            // Create header line
            string[] csvHeadersArray = selectedNodeHeaders;
            for (int i = 0; i < selectedNodeHeaders.Length; i++) {
                switch(selectedNodeHeaders[i]) {
                    case "Query Parameters":
                        csvHeadersArray[i] = string.Join(delimiter, selectedQueryParameters);
                        break;
                    case "Geo":
                        csvHeadersArray[i] = string.Join(delimiter, selectedGeoParameters);
                        break;                    
                }
            }
            string csvHeaders = string.Join(delimiter, csvHeadersArray);
            int headersLength = csvHeaders.Length;

            outputDir = txt_outputDir.Text;
            var outputFilename = txt_OutputFilename.Text;
            outputFile = outputDir + "\\" + outputFilename + ".tab";

            parsedLines = 0;
            string line;

            if (!File.Exists(outputFile)) {
                File.Create(outputFile).Dispose();
            }

            using (StreamReader sr = new StreamReader(logFile)) {
                using (StreamWriter sw = new StreamWriter(outputFile, false)) {
                    sw.WriteLine(csvHeaders);
                    line = null;
                    while ((line = sr.ReadLine()) != null) {
                        if (line[0] != '#') {
                            string parsedLine = ParseLineForTAB(line, selectedNodeIndexes, selectedQueryParameters, selectedGeoParameters);
                            sw.WriteLine(parsedLine);
                        }
                        parsedLines++;
                    }
                }
            }
        }

        private string ParseLineForTAB(string line, int[] selectedNodeIndexes, string[] selectedQueryParameters, string[] selectedGeoParameters)
        {
            string result = "";

            string[] resultArray = new string[selectedNodeIndexes.Length];

            if (line[0] != '#') {

                string[] splitLine = line.Split(' ');

                if (splitLine.Length > 7) {

                    for (int i = 0; i < selectedNodeIndexes.Length; i++) {
                        int splitLineIndex = selectedNodeIndexes[i];
                        switch (splitLineIndex) {
                            case 7: // Query Param Index
                                resultArray[i] = ParseLineForQueryParams(splitLine[splitLineIndex], selectedQueryParameters);
                                break;
                            case 14: // Geo Param Index
                                resultArray[i] = ParseLineForQueryParams(splitLine[splitLineIndex], selectedGeoParameters);
                                break;
                            default:
                                resultArray[i] = splitLine[splitLineIndex];
                                break;
                        }
                    }
                }
            }

            result = decode(joinParsedLine(resultArray));

            return result;
        }

        public string ParseLineForQueryParams(string queryParamsBlock, string[] selectedQueryParameters)
        {
            string result = "";

            string[] resultArray = new string[selectedQueryParameters.Length];

            var allQueryStringsInLine = new NameValueCollection();

            allQueryStringsInLine = HttpUtility.ParseQueryString(queryParamsBlock);

            for(int i = 0; i < resultArray.Length; i++) {
                resultArray[i] = allQueryStringsInLine.Get(selectedQueryParameters[i]);
            }

            result = joinQueryParams(resultArray);

            return result;
        }

        private void CreateJSONFile(object sender, int[] selectedNodeIndexes, string[] selectedNodeHeaders, string[] selectedQueryParameters, string[] selectedGeoParameters, string logFile)
        {
            return;
        }

        #endregion

        #region Open File Functions

        private void OpenLogFileWithExcel()
        {
            try {
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = "Excel";
                startInfo.Arguments = "\"" + outputFile + "\"";
                Process.Start(startInfo);
            } catch(Exception e) {
                ShowErrorBox("Error while opening Excel. Is it installed? \n" + e.Message);
            }
        }

        #endregion

        #endregion

        #region Helper Functions

        private string ShowOpenFileDialog(string initFile, string filter)
        {
            string result = null;

            string startDirectory = (!string.IsNullOrWhiteSpace(initFile) && File.Exists(initFile))
                ? Path.GetDirectoryName(initFile)
                : Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            var openFileDialog = new OpenFileDialog
            {
                InitialDirectory = startDirectory,
                Filter = filter,
                RestoreDirectory = true
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                try {
                    result = openFileDialog.FileName;
                }
                catch (Exception ex) {
                    ShowErrorBox("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }

            return result;
        }

        private string ShowOpenFolderDialog(string startDir, string filter = "")
        {
            string result = null;

            string startDirectory = string.IsNullOrWhiteSpace(startDir) || !Directory.Exists(startDir) ?
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) :
                startDir;

            var folderBrowserDialog = new FolderBrowserDialog
            {
                SelectedPath = startDirectory,
                ShowNewFolderButton = false                
            };

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {                
                    result = folderBrowserDialog.SelectedPath;
                }
                catch (Exception ex)
                {
                    ShowErrorBox("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }

            return result;
        }

        private void Print(object text)
        {
            Console.Out.WriteLine(text);
        }

        private void ExecuteSystemProcess(ProcessStartInfo psi)
        {
            Process process = Process.Start(psi);
            process.WaitForExit();
        }

        private void ShowErrorBox(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void StartWaiting(bool showWait)
        {
            tasksRunning = showWait ? tasksRunning + 1 : tasksRunning - 1;

            if (tasksRunning == 1) {
                Cursor = Cursors.WaitCursor;
                SetButtonsEnabled(false);
            } else if (tasksRunning == 0) {
                Cursor = Cursors.Default;
                SetButtonsEnabled(true);
            }
        }

        private void SetButtonsEnabled(bool enabled)
        {
            btn_AddQueryParams.Enabled = enabled;
            btn_ExtractLogFiles.Enabled = enabled;
            btn_FullScan.Enabled = enabled;
            btn_GzFileDirectory.Enabled = enabled;
            btn_QuickScan.Enabled = enabled;
            btn_SevenZip.Enabled = enabled;
            btn_singleLogFile.Enabled = enabled;
            btn_start.Enabled = enabled;
            btn_submitSingleLogFile.Enabled = enabled;
            btn_Excel.Enabled = enabled;
            btn_Explorer.Enabled = enabled;
        }

        #endregion

        private void rdio_Decode_CheckedChanged(object sender, EventArgs e)
        {
            SetDecoder();
        }

        private void SetDecoder()
        {
            if (rdio_Decode_0.Checked) {
                decode = delegate (string encodeVar) { return encodeVar; };
            } else if (rdio_Decode_1.Checked) {
                decode = delegate (string encodeVar) { return Uri.UnescapeDataString(encodeVar).Replace(Environment.NewLine, " "); };
            } else if (rdio_Decode_2.Checked) {
                decode = delegate (string encodeVar) { return Uri.UnescapeDataString(Uri.UnescapeDataString(encodeVar)).Replace(Environment.NewLine, " "); };
            } else {
                decode = delegate (string encodeVar) { return encodeVar; };
            }
        }

        private void chk_Quotes_CheckedChanged(object sender, EventArgs e)
        {
            SetJoinedLogic();
        }

        private void SetJoinedLogic()
        {
            if(chk_Quotes.Checked) {
                joinQueryParams = delegate (string[] queryParamArray) { return string.Join("\"" + delimiter + "\"", queryParamArray); };
                joinParsedLine = delegate (string[] lineColumnArray) { return "\"" + string.Join("\"" + delimiter + "\"", lineColumnArray) + "\""; };
            } else {
                joinQueryParams = delegate (string[] queryParamArray) { return string.Join(delimiter, queryParamArray); };
                joinParsedLine = delegate (string[] lineColumnArray) { return string.Join(delimiter, lineColumnArray); };
            }
        }

        private void btn_Explorer_Click(object sender, EventArgs e)
        {
            Process.Start(Path.GetDirectoryName(outputFile));
        }

        private void btn_outputDir_Click(object sender, EventArgs e)
        {
            LocateOutputDir();
        }

        private void LocateOutputDir()
        {
            LocateAndUpdateUI(ShowOpenFolderDialog, txt_outputDir);
        }

        private void treeView_fields_KeyPress(object sender, KeyEventArgs e)
        {
            // if there is a currently selected node
            var selectedNode = treeView_fields.SelectedNode;

            if(selectedNode != null) {
                // if the Enter key was pressed
                if (e.KeyCode == Keys.Enter) {
                    selectedNode.Checked = !selectedNode.Checked;
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                }
            }
        }


    }
}