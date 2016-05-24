using System;
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
        }

        private void lbl_elapsedTimeValue_Click(object sender, EventArgs e)
        {
        }

        private void btn_inputFile_Click(object sender, EventArgs e)
        {
            LoadInputFile();
        }

        private void btn_output_Click(object sender, EventArgs e)
        {
            SetOutputPath();
        }

        private void LoadInputFile()
        {
            // Show openFileDialog and get log file path.
            var filePath = ShowOpenFileDialog();

            // If user closed the dialog, do nothing.
            if (string.IsNullOrEmpty(filePath)) {
                return;
            }

            // Check if valid file
            if (IsValidLogFile(filePath)) {
                // Enable UI elements
                SetUiElements(true);

                // Paste filepath into txt_inputFile
                txt_inputFile.Text = filePath;
                Program.InputFilePath = filePath;

                // Set Output to be same destination as input.
                txt_output.Text = GetInputFilePath();

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
            btn_output.Enabled = isValid;
            txt_output.Enabled = isValid;
            grp_statistics.Enabled = isValid;
            grp_outputConfig.Enabled = isValid;
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

        private string ShowOpenFileDialog()
        {
            string result = null;

            var openFileDialog = new OpenFileDialog
            {
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                Filter = @"txt files (*.txt)|*.txt|log files (*.log)|*.log",
                FilterIndex = 2,
                RestoreDirectory = true
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                try {
                    // Clear existing txt values.
                    txt_inputFile.Text = "";
                    txt_output.Text = "";

                    result = openFileDialog.FileName;
                }
                catch (Exception ex) {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }

            return result;
        }

        private void SetOutputPath()
        {
            // Show openFileDialog and get log file path.
            var outputPath = ShowFolderBrowserDialog();

            if (outputPath != null) {
                txt_output.Text = outputPath;
                Program.OutputPath = outputPath;
            }
        }

        private static string ShowFolderBrowserDialog()
        {
            string result = null;

            var folderBrowserDialog = new FolderBrowserDialog {SelectedPath = GetInputFilePath()};

            // If we have already selected an input file, set the start location to this location.

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK) {
                try {
                    if (!string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath)) {
                        result = folderBrowserDialog.SelectedPath;
                    }
                }
                catch (Exception ex) {
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
    }
}