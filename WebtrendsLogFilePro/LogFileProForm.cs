using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebtrendsLogFilePro
{
    public partial class LogFileProForm : Form
    {
        public LogFileProForm()
        {
            InitializeComponent();
        }

        private void lbl_elapsedTimeValue_Click(object sender, EventArgs e)
        {

        }

        private void btn_inputFile_Click(object sender, EventArgs e)
        {
            LoadInputFile();
        }

        private static void LoadInputFile()
        {
            // Show dialog to select file
            ShowOpenFileDialog();

            // Check if valid file

            // If valid
            //  Paste filepath into txt_inputFile

            // Get total line count

            // Else, show error
        }

        private static void ShowOpenFileDialog()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                Filter = @"txt files (*.txt)|*.txt|log files (*.log)|*.log",
                FilterIndex = 2,
                RestoreDirectory = true
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Stream myStream = null;
                    if ((myStream = openFileDialog.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            // Insert code to read the stream here.
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }
    }
}
