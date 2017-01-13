using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WebtrendsLogFilePro
{
    public partial class LogFileProForm : Form
    {
        public LogFileProForm()
        {
            InitializeComponent();

            // Set default UI values
            cmb_outputFormat.SelectedIndex = 0;
            SetUiElements(false);

            // Set dev values
            txt_gzFileDirectory.Text = @"C:\Users\buckleyj\Documents\_Clients\Coca Cola\Logs\dcs2228kup94grmx84kkv4pt5_9z3q";

            initFields();
        }

        private void initFields()
        {
            // Create global fields objects.
            // Standard --> date time c-ip cs-username cs-host cs-method cs-uri-stem sc-status sc-bytes cs-version cs(User-Agent) cs(Cookie) cs(Referer) dcs-dns origin-id dcs-id
            // Query Parameters --> [Perform Initial Scan]
            // Geo --> ar cc ci cn co cs dm dmc dms nt rc rs tz

            treeView_fields.Nodes.Add("All Fields");

            treeView_fields.Nodes[0].Nodes.Add(new FieldHeaderNode(0, "date", "Date"));
            treeView_fields.Nodes[0].Nodes.Add(new FieldHeaderNode(1, "time", "Time"));
            treeView_fields.Nodes[0].Nodes.Add(new FieldHeaderNode(2, "c-ip", "Client IP"));
            treeView_fields.Nodes[0].Nodes.Add(new FieldHeaderNode(3, "cs-username", "Auth Username"));
            treeView_fields.Nodes[0].Nodes.Add(new FieldHeaderNode(4, "cs-host", "Domain"));
            treeView_fields.Nodes[0].Nodes.Add(new FieldHeaderNode(5, "cs-method", "Client Method"));

            FieldHeaderNode queryParams = new FieldHeaderNode(6, "cs-uri-stem", "Query Parameters");
            queryParams.Nodes.Add(new TreeNode("WT.co_f"));
            queryParams.Nodes.Add(new TreeNode("WT.am"));


            treeView_fields.Nodes[0].Nodes.Add(queryParams);
            treeView_fields.Nodes[0].Nodes.Add(new FieldHeaderNode(7, "sc-status", "SC Status"));
            treeView_fields.Nodes[0].Nodes.Add(new FieldHeaderNode(8, "sc-bytes", "SC Bytes"));
            treeView_fields.Nodes[0].Nodes.Add(new FieldHeaderNode(9, "cs-version", "Protocol Version"));
            treeView_fields.Nodes[0].Nodes.Add(new FieldHeaderNode(10, "cs(User-Agent)", "User Agent"));
            treeView_fields.Nodes[0].Nodes.Add(new FieldHeaderNode(11, "cs(Cookie)", "User Cookie"));
            treeView_fields.Nodes[0].Nodes.Add(new FieldHeaderNode(12, "cs(Referrer)", "Referrer"));

            FieldHeaderNode geoParams = new FieldHeaderNode(13, "dcs-geo", "Geo");
            geoParams.Nodes.Add(new TreeNode("ar"));
            geoParams.Nodes.Add(new TreeNode("cc"));

            treeView_fields.Nodes[0].Nodes.Add(geoParams);
            treeView_fields.Nodes[0].Nodes.Add(new FieldHeaderNode(14, "dcs-dns", "DNS"));
            treeView_fields.Nodes[0].Nodes.Add(new FieldHeaderNode(15, "origin-id", "Origin ID"));
            treeView_fields.Nodes[0].Nodes.Add(new FieldHeaderNode(16, "dcs-id", "DataSource ID"));
        }

        private void btn_singleLogFile_Click(object sender, EventArgs e)
        {
            LoadSingleLogFile();
        }

        private void btn_submitSingleLogFile_Click(object sender, EventArgs e)
        {

        }

        private void btn_gzFileDirectory_Click(object sender, EventArgs e)
        {
            LoadInputFromDirectory();
        }

        private void LoadInputFromDirectory()
        {
            string filePath = ShowOpenFolderDialog();

            // If user closed the dialog, do nothing.
            if (string.IsNullOrEmpty(filePath)) {
                return;
            } else {
                txt_gzFileDirectory.Text = filePath;
            }
        }

        private void LoadSingleLogFile()
        {
            // Show openFileDialog and get log file path.
            var filePath = txt_singleLogFile.Text;

            // If user closed the dialog, do nothing.
            if (string.IsNullOrEmpty(filePath) && File.Exists(filePath)) {
                showErrorBox("Invalid Single Log File");
                return;
            }

            // Check if valid file
            if (IsValidLogFile(filePath)) {
                // Enable UI elements
                SetUiElements(true);

                // Paste filepath into txt_inputFile
                txt_singleLogFile.Text = filePath;
                Program.InputFilePath = filePath;

                // Set Output to be same destination as input.
                //txt_output.Text = GetInputFilePath();

                // Before we do the row count, show a loading cursor.
                Cursor.Current = Cursors.WaitCursor;

                // Get total line count
                var rowCount = File.ReadLines(filePath).Count();
                lbl_totalRowsValue.Text = rowCount.ToString();

                // Counting complete, return the cursor to normal.
                Cursor.Current = Cursors.Arrow;
            } else {
                // Disable UI elements
                SetUiElements(false);

                // Show error
                MessageBox.Show("Error: File was invalid. Are you sure it was a Webtrends log file?");
            }
        }

        private void SetUiElements(bool isValid)
        {
            //treeView_fields.Enabled = isValid;
            grp_outputConfig.Enabled = isValid;
            grp_statistics.Enabled = isValid;
            btn_start.Enabled = isValid;
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

        private string ShowOpenFileDialog(string initFile)
        {
            string result = null;

            string startDirectory = (!string.IsNullOrWhiteSpace(initFile) && File.Exists(initFile))
                ? Path.GetDirectoryName(initFile)
                : Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            var openFileDialog = new OpenFileDialog
            {
                InitialDirectory = startDirectory,
                Filter = @"txt files (*.txt)|*.txt|log files (*.log)|*.log",
                FilterIndex = 2,
                RestoreDirectory = true
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                try {
                    // Clear existing txt values.
                    txt_singleLogFile.Text = "";

                    result = openFileDialog.FileName;
                }
                catch (Exception ex) {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }

            return result;
        }

        private string ShowOpenFolderDialog()
        {
            string result = null;

            string startDirectory = string.IsNullOrWhiteSpace(txt_gzFileDirectory.Text) ?
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) :
                txt_gzFileDirectory.Text;

            var folderBrowserDialog = new FolderBrowserDialog
            {
                SelectedPath = startDirectory,
                ShowNewFolderButton = false
            };

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Clear existing txt values.
                    txt_gzFileDirectory.Text = "";                    

                    result = folderBrowserDialog.SelectedPath;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }

            return result;
        }

        private static string GetInputFilePath()
        {
            string result = Environment.SpecialFolder.MyDocuments.ToString();

            if (!string.IsNullOrEmpty(Program.InputFilePath)) {
                result = Path.GetDirectoryName(Program.InputFilePath);
            }

            return result;
        }

        private void ExtractLogFilesAndMerge()
        {
            // Get folder path from txt box
            string gzFolderPath = txt_gzFileDirectory.Text;
            if(string.IsNullOrWhiteSpace(gzFolderPath)) {
                showErrorBox("Gz Folder Directory value is empty!");
                return;
            }

            // Confirm it contains gz files
            string[] gzFiles = Directory.GetFiles(gzFolderPath, "*.gz", SearchOption.TopDirectoryOnly);
            if(gzFiles.Length == 0) {
                showErrorBox("Folder contains no .gz files!");
                return;
            }

            // Confirm 7zip.exe exists
            string sZip = txt_sevenZip.Text;
            if(string.IsNullOrWhiteSpace(sZip) || !File.Exists(sZip)) {
                showErrorBox("Cannot find 7z.exe file!");
                return;
            }

            // Start Extraction/Merge Process
            try {
                // Set cursor to be hourglass
                Cursor.Current = Cursors.WaitCursor;

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

            } catch (Exception e) {
                showErrorBox("Failed to extract .gz files!" + Environment.NewLine + e.Message);
                return;
            } finally {
                Cursor.Current = Cursors.Default;
            }

            // Set the newly created file as the Single Log File text.
            txt_singleLogFile.Text = gzFolderPath + "\\single-log-file.log";

        }

        private void Print(string text)
        {
            System.Console.Out.WriteLine(text);
        }

        private void ExecuteSystemProcess(ProcessStartInfo psi)
        {
            Process process = Process.Start(psi);
            process.WaitForExit();
        }

        private void showErrorBox(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void grp_outputConfig_Enter(object sender, EventArgs e)
        {

        }

        private void lbl_elapsedTimeValue_Click_1(object sender, EventArgs e)
        {

        }

        private void treeView_fields_AfterCheck(object sender, TreeViewEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void LogFileProForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_extractLogFiles_Click(object sender, EventArgs e)
        {
            ExtractLogFilesAndMerge();
        }
    }
}