using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace WebtrendsLogFilePro
{
    partial class LogFileProForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogFileProForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txt_output = new System.Windows.Forms.TextBox();
            this.btn_inputFile = new System.Windows.Forms.Button();
            this.btn_output = new System.Windows.Forms.Button();
            this.txt_inputFile = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_help = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_start = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.grp_statistics = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_totalHeadersTitle = new System.Windows.Forms.Label();
            this.lbl_totalRowsParsedTitle = new System.Windows.Forms.Label();
            this.lbl_elapsedTimeTitle = new System.Windows.Forms.Label();
            this.lbl_totalRowsTitle = new System.Windows.Forms.Label();
            this.lbl_totalRowsValue = new System.Windows.Forms.Label();
            this.lbl_totalHeadersValue = new System.Windows.Forms.Label();
            this.lbl_totalRowsParsedValue = new System.Windows.Forms.Label();
            this.lbl_elapsedTimeValue = new System.Windows.Forms.Label();
            this.grp_outputConfig = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_outputTypeTitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_outputFileName = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cmb_outputFormat = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.grp_statistics.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.grp_outputConfig.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 4F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(560, 227);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.txt_output, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.btn_inputFile, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_output, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.txt_inputFile, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 7);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(554, 54);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // txt_output
            // 
            this.txt_output.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_output.Location = new System.Drawing.Point(110, 30);
            this.txt_output.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txt_output.Name = "txt_output";
            this.txt_output.Size = new System.Drawing.Size(434, 20);
            this.txt_output.TabIndex = 3;
            // 
            // btn_inputFile
            // 
            this.btn_inputFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_inputFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_inputFile.Location = new System.Drawing.Point(10, 2);
            this.btn_inputFile.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_inputFile.Name = "btn_inputFile";
            this.btn_inputFile.Size = new System.Drawing.Size(90, 22);
            this.btn_inputFile.TabIndex = 0;
            this.btn_inputFile.Text = "Input File";
            this.btn_inputFile.UseVisualStyleBackColor = true;
            this.btn_inputFile.Click += new System.EventHandler(this.btn_inputFile_Click);
            // 
            // btn_output
            // 
            this.btn_output.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_output.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_output.Location = new System.Drawing.Point(10, 29);
            this.btn_output.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_output.Name = "btn_output";
            this.btn_output.Size = new System.Drawing.Size(90, 22);
            this.btn_output.TabIndex = 1;
            this.btn_output.Text = "Output";
            this.btn_output.UseVisualStyleBackColor = true;
            this.btn_output.Click += new System.EventHandler(this.btn_output_Click);
            // 
            // txt_inputFile
            // 
            this.txt_inputFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_inputFile.Location = new System.Drawing.Point(110, 3);
            this.txt_inputFile.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txt_inputFile.Name = "txt_inputFile";
            this.txt_inputFile.Size = new System.Drawing.Size(434, 20);
            this.txt_inputFile.TabIndex = 2;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tableLayoutPanel3.Controls.Add(this.btn_help, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btn_close, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.btn_start, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.progressBar, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 190);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(554, 34);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // btn_help
            // 
            this.btn_help.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_help.Location = new System.Drawing.Point(10, 6);
            this.btn_help.Margin = new System.Windows.Forms.Padding(10, 0, 5, 0);
            this.btn_help.Name = "btn_help";
            this.btn_help.Size = new System.Drawing.Size(25, 22);
            this.btn_help.TabIndex = 3;
            this.btn_help.Text = "?";
            this.btn_help.UseVisualStyleBackColor = true;
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.Location = new System.Drawing.Point(424, 6);
            this.btn_close.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(120, 22);
            this.btn_close.TabIndex = 0;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            // 
            // btn_start
            // 
            this.btn_start.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_start.Location = new System.Drawing.Point(284, 6);
            this.btn_start.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(120, 22);
            this.btn_start.TabIndex = 1;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(50, 7);
            this.progressBar.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(214, 20);
            this.progressBar.TabIndex = 2;
            this.progressBar.Value = 50;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 220F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.grp_statistics, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.grp_outputConfig, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 67);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(554, 117);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // grp_statistics
            // 
            this.grp_statistics.Controls.Add(this.tableLayoutPanel5);
            this.grp_statistics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grp_statistics.Location = new System.Drawing.Point(14, 3);
            this.grp_statistics.Margin = new System.Windows.Forms.Padding(14, 3, 14, 3);
            this.grp_statistics.Name = "grp_statistics";
            this.grp_statistics.Size = new System.Drawing.Size(192, 111);
            this.grp_statistics.TabIndex = 3;
            this.grp_statistics.TabStop = false;
            this.grp_statistics.Text = "Statistics";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.lbl_totalHeadersTitle, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.lbl_totalRowsParsedTitle, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.lbl_elapsedTimeTitle, 0, 3);
            this.tableLayoutPanel5.Controls.Add(this.lbl_totalRowsTitle, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.lbl_totalRowsValue, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.lbl_totalHeadersValue, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.lbl_totalRowsParsedValue, 1, 2);
            this.tableLayoutPanel5.Controls.Add(this.lbl_elapsedTimeValue, 1, 3);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 4;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(186, 92);
            this.tableLayoutPanel5.TabIndex = 3;
            // 
            // lbl_totalHeadersTitle
            // 
            this.lbl_totalHeadersTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_totalHeadersTitle.AutoSize = true;
            this.lbl_totalHeadersTitle.Location = new System.Drawing.Point(3, 28);
            this.lbl_totalHeadersTitle.Name = "lbl_totalHeadersTitle";
            this.lbl_totalHeadersTitle.Size = new System.Drawing.Size(114, 13);
            this.lbl_totalHeadersTitle.TabIndex = 1;
            this.lbl_totalHeadersTitle.Text = "Total Headers:";
            // 
            // lbl_totalRowsParsedTitle
            // 
            this.lbl_totalRowsParsedTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_totalRowsParsedTitle.AutoSize = true;
            this.lbl_totalRowsParsedTitle.Location = new System.Drawing.Point(3, 51);
            this.lbl_totalRowsParsedTitle.Name = "lbl_totalRowsParsedTitle";
            this.lbl_totalRowsParsedTitle.Size = new System.Drawing.Size(114, 13);
            this.lbl_totalRowsParsedTitle.TabIndex = 2;
            this.lbl_totalRowsParsedTitle.Text = "Total Rows Parsed:";
            // 
            // lbl_elapsedTimeTitle
            // 
            this.lbl_elapsedTimeTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_elapsedTimeTitle.AutoSize = true;
            this.lbl_elapsedTimeTitle.Location = new System.Drawing.Point(3, 74);
            this.lbl_elapsedTimeTitle.Name = "lbl_elapsedTimeTitle";
            this.lbl_elapsedTimeTitle.Size = new System.Drawing.Size(114, 13);
            this.lbl_elapsedTimeTitle.TabIndex = 3;
            this.lbl_elapsedTimeTitle.Text = "Elapsed Time:";
            // 
            // lbl_totalRowsTitle
            // 
            this.lbl_totalRowsTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_totalRowsTitle.AutoSize = true;
            this.lbl_totalRowsTitle.Location = new System.Drawing.Point(3, 5);
            this.lbl_totalRowsTitle.Name = "lbl_totalRowsTitle";
            this.lbl_totalRowsTitle.Size = new System.Drawing.Size(114, 13);
            this.lbl_totalRowsTitle.TabIndex = 0;
            this.lbl_totalRowsTitle.Text = "Total Rows:";
            // 
            // lbl_totalRowsValue
            // 
            this.lbl_totalRowsValue.AutoSize = true;
            this.lbl_totalRowsValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_totalRowsValue.Location = new System.Drawing.Point(123, 0);
            this.lbl_totalRowsValue.Name = "lbl_totalRowsValue";
            this.lbl_totalRowsValue.Size = new System.Drawing.Size(60, 23);
            this.lbl_totalRowsValue.TabIndex = 4;
            this.lbl_totalRowsValue.Text = "0";
            this.lbl_totalRowsValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_totalHeadersValue
            // 
            this.lbl_totalHeadersValue.AutoSize = true;
            this.lbl_totalHeadersValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_totalHeadersValue.Location = new System.Drawing.Point(123, 23);
            this.lbl_totalHeadersValue.Name = "lbl_totalHeadersValue";
            this.lbl_totalHeadersValue.Size = new System.Drawing.Size(60, 23);
            this.lbl_totalHeadersValue.TabIndex = 5;
            this.lbl_totalHeadersValue.Text = "0";
            this.lbl_totalHeadersValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_totalRowsParsedValue
            // 
            this.lbl_totalRowsParsedValue.AutoSize = true;
            this.lbl_totalRowsParsedValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_totalRowsParsedValue.Location = new System.Drawing.Point(123, 46);
            this.lbl_totalRowsParsedValue.Name = "lbl_totalRowsParsedValue";
            this.lbl_totalRowsParsedValue.Size = new System.Drawing.Size(60, 23);
            this.lbl_totalRowsParsedValue.TabIndex = 6;
            this.lbl_totalRowsParsedValue.Text = "0";
            this.lbl_totalRowsParsedValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_elapsedTimeValue
            // 
            this.lbl_elapsedTimeValue.AutoSize = true;
            this.lbl_elapsedTimeValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_elapsedTimeValue.Location = new System.Drawing.Point(123, 69);
            this.lbl_elapsedTimeValue.Name = "lbl_elapsedTimeValue";
            this.lbl_elapsedTimeValue.Size = new System.Drawing.Size(60, 23);
            this.lbl_elapsedTimeValue.TabIndex = 7;
            this.lbl_elapsedTimeValue.Text = "00:00:00";
            this.lbl_elapsedTimeValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grp_outputConfig
            // 
            this.grp_outputConfig.Controls.Add(this.tableLayoutPanel6);
            this.grp_outputConfig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grp_outputConfig.Location = new System.Drawing.Point(223, 3);
            this.grp_outputConfig.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.grp_outputConfig.Name = "grp_outputConfig";
            this.grp_outputConfig.Size = new System.Drawing.Size(321, 111);
            this.grp_outputConfig.TabIndex = 4;
            this.grp_outputConfig.TabStop = false;
            this.grp_outputConfig.Text = "Output Config";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Controls.Add(this.lbl_outputTypeTitle, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel6.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel6.Controls.Add(this.lbl_outputFileName, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.label7, 1, 2);
            this.tableLayoutPanel6.Controls.Add(this.label8, 1, 3);
            this.tableLayoutPanel6.Controls.Add(this.textBox1, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.cmb_outputFormat, 1, 1);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 4;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(315, 92);
            this.tableLayoutPanel6.TabIndex = 4;
            // 
            // lbl_outputTypeTitle
            // 
            this.lbl_outputTypeTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_outputTypeTitle.AutoSize = true;
            this.lbl_outputTypeTitle.Location = new System.Drawing.Point(3, 28);
            this.lbl_outputTypeTitle.Name = "lbl_outputTypeTitle";
            this.lbl_outputTypeTitle.Size = new System.Drawing.Size(114, 13);
            this.lbl_outputTypeTitle.TabIndex = 1;
            this.lbl_outputTypeTitle.Text = "Format:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Total Rows Parsed:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Elapsed Time:";
            // 
            // lbl_outputFileName
            // 
            this.lbl_outputFileName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_outputFileName.AutoSize = true;
            this.lbl_outputFileName.Location = new System.Drawing.Point(3, 5);
            this.lbl_outputFileName.Name = "lbl_outputFileName";
            this.lbl_outputFileName.Size = new System.Drawing.Size(114, 13);
            this.lbl_outputFileName.TabIndex = 0;
            this.lbl_outputFileName.Text = "Filename:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(123, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(189, 23);
            this.label7.TabIndex = 6;
            this.label7.Text = "0";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(123, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(189, 23);
            this.label8.TabIndex = 7;
            this.label8.Text = "00:00:00";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(120, 0);
            this.textBox1.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(190, 20);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "Output";
            // 
            // cmb_outputFormat
            // 
            this.cmb_outputFormat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmb_outputFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_outputFormat.FormattingEnabled = true;
            this.cmb_outputFormat.Items.AddRange(new object[] {
            "JSON",
            ".csv (Comma Delimited)"});
            this.cmb_outputFormat.Location = new System.Drawing.Point(120, 23);
            this.cmb_outputFormat.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.cmb_outputFormat.Name = "cmb_outputFormat";
            this.cmb_outputFormat.Size = new System.Drawing.Size(190, 21);
            this.cmb_outputFormat.TabIndex = 9;
            // 
            // LogFileProForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 227);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LogFileProForm";
            this.Text = "Webtrends Log File Pro";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.grp_statistics.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.grp_outputConfig.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btn_inputFile;
        private TextBox txt_output;
        private Button btn_output;
        private TextBox txt_inputFile;
        private TableLayoutPanel tableLayoutPanel3;
        private Button btn_close;
        private Button btn_start;
        private ProgressBar progressBar;
        private Button btn_help;
        private TableLayoutPanel tableLayoutPanel4;
        private GroupBox grp_statistics;
        private TableLayoutPanel tableLayoutPanel5;
        private Label lbl_totalHeadersTitle;
        private Label lbl_totalRowsParsedTitle;
        private Label lbl_elapsedTimeTitle;
        private Label lbl_totalRowsTitle;
        private Label lbl_totalRowsValue;
        private Label lbl_totalHeadersValue;
        private Label lbl_totalRowsParsedValue;
        private Label lbl_elapsedTimeValue;
        private GroupBox grp_outputConfig;
        private TableLayoutPanel tableLayoutPanel6;
        private Label lbl_outputTypeTitle;
        private Label label2;
        private Label label3;
        private Label lbl_outputFileName;
        private Label label7;
        private Label label8;
        private TextBox textBox1;
        private ComboBox cmb_outputFormat;
    }
}

