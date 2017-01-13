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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogFileProForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_help = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_start = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.grp_statistics = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_totalParsedRows = new System.Windows.Forms.Label();
            this.lbl_elapsedTimeTitle = new System.Windows.Forms.Label();
            this.lbl_totalRowsTitle = new System.Windows.Forms.Label();
            this.lbl_totalRowsValue = new System.Windows.Forms.Label();
            this.lbl_totalHeadersValue = new System.Windows.Forms.Label();
            this.lbl_elapsedTimeValue = new System.Windows.Forms.Label();
            this.grp_outputConfig = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_outputTypeTitle = new System.Windows.Forms.Label();
            this.lbl_outputFileName = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cmb_outputFormat = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_gzFileDirectory = new System.Windows.Forms.Button();
            this.btn_singleLogFile = new System.Windows.Forms.Button();
            this.txt_singleLogFile = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txt_gzFileDirectory = new System.Windows.Forms.TextBox();
            this.txt_sevenZip = new System.Windows.Forms.TextBox();
            this.btn_extractLogFiles = new System.Windows.Forms.Button();
            this.btn_submitSingleLogFile = new System.Windows.Forms.Button();
            this.treeView_fields = new WebtrendsLogFilePro.TriStateTreeView();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.grp_statistics.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.grp_outputConfig.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.MinimumSize = new System.Drawing.Size(593, 400);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 4F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(593, 400);
            this.tableLayoutPanel1.TabIndex = 0;
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
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 363);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(587, 34);
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
            this.btn_close.Location = new System.Drawing.Point(457, 6);
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
            this.btn_start.Location = new System.Drawing.Point(317, 6);
            this.btn_start.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(120, 22);
            this.btn_start.TabIndex = 1;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel8, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 117);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(587, 240);
            this.tableLayoutPanel4.TabIndex = 2;
            this.tableLayoutPanel4.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel4_Paint);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.grp_statistics, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.grp_outputConfig, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(290, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 3;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(294, 234);
            this.tableLayoutPanel5.TabIndex = 6;
            // 
            // grp_statistics
            // 
            this.grp_statistics.Controls.Add(this.tableLayoutPanel7);
            this.grp_statistics.Dock = System.Windows.Forms.DockStyle.Top;
            this.grp_statistics.Location = new System.Drawing.Point(3, 81);
            this.grp_statistics.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.grp_statistics.Name = "grp_statistics";
            this.grp_statistics.Size = new System.Drawing.Size(281, 98);
            this.grp_statistics.TabIndex = 6;
            this.grp_statistics.TabStop = false;
            this.grp_statistics.Text = "Progress";
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Controls.Add(this.lbl_totalParsedRows, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.lbl_elapsedTimeTitle, 0, 2);
            this.tableLayoutPanel7.Controls.Add(this.lbl_totalRowsTitle, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.lbl_totalRowsValue, 1, 0);
            this.tableLayoutPanel7.Controls.Add(this.lbl_totalHeadersValue, 1, 1);
            this.tableLayoutPanel7.Controls.Add(this.lbl_elapsedTimeValue, 1, 2);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 3;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(275, 79);
            this.tableLayoutPanel7.TabIndex = 3;
            // 
            // lbl_totalParsedRows
            // 
            this.lbl_totalParsedRows.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_totalParsedRows.AutoSize = true;
            this.lbl_totalParsedRows.Location = new System.Drawing.Point(3, 32);
            this.lbl_totalParsedRows.Name = "lbl_totalParsedRows";
            this.lbl_totalParsedRows.Size = new System.Drawing.Size(114, 13);
            this.lbl_totalParsedRows.TabIndex = 1;
            this.lbl_totalParsedRows.Text = "Parsed Rows:";
            // 
            // lbl_elapsedTimeTitle
            // 
            this.lbl_elapsedTimeTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_elapsedTimeTitle.AutoSize = true;
            this.lbl_elapsedTimeTitle.Location = new System.Drawing.Point(3, 59);
            this.lbl_elapsedTimeTitle.Name = "lbl_elapsedTimeTitle";
            this.lbl_elapsedTimeTitle.Size = new System.Drawing.Size(114, 13);
            this.lbl_elapsedTimeTitle.TabIndex = 3;
            this.lbl_elapsedTimeTitle.Text = "Elapsed Time:";
            // 
            // lbl_totalRowsTitle
            // 
            this.lbl_totalRowsTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_totalRowsTitle.AutoSize = true;
            this.lbl_totalRowsTitle.Location = new System.Drawing.Point(3, 6);
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
            this.lbl_totalRowsValue.Size = new System.Drawing.Size(149, 26);
            this.lbl_totalRowsValue.TabIndex = 4;
            this.lbl_totalRowsValue.Text = "0";
            this.lbl_totalRowsValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_totalHeadersValue
            // 
            this.lbl_totalHeadersValue.AutoSize = true;
            this.lbl_totalHeadersValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_totalHeadersValue.Location = new System.Drawing.Point(123, 26);
            this.lbl_totalHeadersValue.Name = "lbl_totalHeadersValue";
            this.lbl_totalHeadersValue.Size = new System.Drawing.Size(149, 26);
            this.lbl_totalHeadersValue.TabIndex = 5;
            this.lbl_totalHeadersValue.Text = "0";
            this.lbl_totalHeadersValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_elapsedTimeValue
            // 
            this.lbl_elapsedTimeValue.AutoSize = true;
            this.lbl_elapsedTimeValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_elapsedTimeValue.Location = new System.Drawing.Point(123, 52);
            this.lbl_elapsedTimeValue.Name = "lbl_elapsedTimeValue";
            this.lbl_elapsedTimeValue.Size = new System.Drawing.Size(149, 27);
            this.lbl_elapsedTimeValue.TabIndex = 7;
            this.lbl_elapsedTimeValue.Text = "00:00:00";
            this.lbl_elapsedTimeValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grp_outputConfig
            // 
            this.grp_outputConfig.Controls.Add(this.tableLayoutPanel6);
            this.grp_outputConfig.Dock = System.Windows.Forms.DockStyle.Top;
            this.grp_outputConfig.Location = new System.Drawing.Point(3, 3);
            this.grp_outputConfig.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.grp_outputConfig.Name = "grp_outputConfig";
            this.grp_outputConfig.Size = new System.Drawing.Size(281, 72);
            this.grp_outputConfig.TabIndex = 5;
            this.grp_outputConfig.TabStop = false;
            this.grp_outputConfig.Text = "Output Config";
            this.grp_outputConfig.Enter += new System.EventHandler(this.grp_outputConfig_Enter);
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Controls.Add(this.lbl_outputTypeTitle, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.lbl_outputFileName, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.textBox1, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.cmb_outputFormat, 1, 1);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(275, 48);
            this.tableLayoutPanel6.TabIndex = 4;
            // 
            // lbl_outputTypeTitle
            // 
            this.lbl_outputTypeTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_outputTypeTitle.AutoSize = true;
            this.lbl_outputTypeTitle.Location = new System.Drawing.Point(3, 29);
            this.lbl_outputTypeTitle.Name = "lbl_outputTypeTitle";
            this.lbl_outputTypeTitle.Size = new System.Drawing.Size(114, 13);
            this.lbl_outputTypeTitle.TabIndex = 1;
            this.lbl_outputTypeTitle.Text = "Format:";
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
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(120, 0);
            this.textBox1.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 20);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "Output";
            // 
            // cmb_outputFormat
            // 
            this.cmb_outputFormat.DisplayMember = "csv";
            this.cmb_outputFormat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmb_outputFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_outputFormat.FormattingEnabled = true;
            this.cmb_outputFormat.Items.AddRange(new object[] {
            "JSON",
            ".csv (Comma Delimited)"});
            this.cmb_outputFormat.Location = new System.Drawing.Point(120, 24);
            this.cmb_outputFormat.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.cmb_outputFormat.Name = "cmb_outputFormat";
            this.cmb_outputFormat.Size = new System.Drawing.Size(150, 21);
            this.cmb_outputFormat.TabIndex = 9;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 1;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.Controls.Add(this.treeView_fields, 0, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel8.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 237F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(281, 237);
            this.tableLayoutPanel8.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(14, 7);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(14, 3, 16, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(563, 104);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input Config";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel2.Controls.Add(this.btn_gzFileDirectory, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_singleLogFile, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.txt_singleLogFile, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.button2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.txt_gzFileDirectory, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.txt_sevenZip, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.btn_extractLogFiles, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_submitSingleLogFile, 2, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33332F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(557, 85);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // btn_gzFileDirectory
            // 
            this.btn_gzFileDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_gzFileDirectory.Location = new System.Drawing.Point(10, 3);
            this.btn_gzFileDirectory.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_gzFileDirectory.Name = "btn_gzFileDirectory";
            this.btn_gzFileDirectory.Size = new System.Drawing.Size(110, 22);
            this.btn_gzFileDirectory.TabIndex = 3;
            this.btn_gzFileDirectory.Text = "Gz Files Directory";
            this.btn_gzFileDirectory.UseVisualStyleBackColor = true;
            this.btn_gzFileDirectory.Click += new System.EventHandler(this.btn_gzFileDirectory_Click);
            // 
            // btn_singleLogFile
            // 
            this.btn_singleLogFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_singleLogFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_singleLogFile.Location = new System.Drawing.Point(10, 59);
            this.btn_singleLogFile.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_singleLogFile.Name = "btn_singleLogFile";
            this.btn_singleLogFile.Size = new System.Drawing.Size(110, 22);
            this.btn_singleLogFile.TabIndex = 0;
            this.btn_singleLogFile.Text = "Single Log File";
            this.btn_singleLogFile.UseVisualStyleBackColor = true;
            this.btn_singleLogFile.Click += new System.EventHandler(this.btn_singleLogFile_Click);
            // 
            // txt_singleLogFile
            // 
            this.txt_singleLogFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_singleLogFile.Location = new System.Drawing.Point(130, 60);
            this.txt_singleLogFile.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txt_singleLogFile.Name = "txt_singleLogFile";
            this.txt_singleLogFile.Size = new System.Drawing.Size(297, 20);
            this.txt_singleLogFile.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(10, 31);
            this.button2.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 22);
            this.button2.TabIndex = 4;
            this.button2.Text = "7zip.exe Location";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // txt_gzFileDirectory
            // 
            this.txt_gzFileDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_gzFileDirectory.Location = new System.Drawing.Point(130, 4);
            this.txt_gzFileDirectory.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txt_gzFileDirectory.Name = "txt_gzFileDirectory";
            this.txt_gzFileDirectory.Size = new System.Drawing.Size(297, 20);
            this.txt_gzFileDirectory.TabIndex = 5;
            // 
            // txt_sevenZip
            // 
            this.txt_sevenZip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_sevenZip.Location = new System.Drawing.Point(130, 32);
            this.txt_sevenZip.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txt_sevenZip.Name = "txt_sevenZip";
            this.txt_sevenZip.Size = new System.Drawing.Size(297, 20);
            this.txt_sevenZip.TabIndex = 6;
            this.txt_sevenZip.Text = "C:\\Program Files\\7-Zip\\7z.exe";
            // 
            // btn_extractLogFiles
            // 
            this.btn_extractLogFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_extractLogFiles.Location = new System.Drawing.Point(437, 3);
            this.btn_extractLogFiles.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.btn_extractLogFiles.Name = "btn_extractLogFiles";
            this.tableLayoutPanel2.SetRowSpan(this.btn_extractLogFiles, 2);
            this.btn_extractLogFiles.Size = new System.Drawing.Size(117, 50);
            this.btn_extractLogFiles.TabIndex = 7;
            this.btn_extractLogFiles.Text = "Extract";
            this.btn_extractLogFiles.UseVisualStyleBackColor = true;
            this.btn_extractLogFiles.Click += new System.EventHandler(this.btn_extractLogFiles_Click);
            // 
            // btn_submitSingleLogFile
            // 
            this.btn_submitSingleLogFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_submitSingleLogFile.Location = new System.Drawing.Point(437, 59);
            this.btn_submitSingleLogFile.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.btn_submitSingleLogFile.Name = "btn_submitSingleLogFile";
            this.btn_submitSingleLogFile.Size = new System.Drawing.Size(117, 22);
            this.btn_submitSingleLogFile.TabIndex = 8;
            this.btn_submitSingleLogFile.Text = "Submit";
            this.btn_submitSingleLogFile.UseVisualStyleBackColor = true;
            this.btn_submitSingleLogFile.Click += new System.EventHandler(this.btn_submitSingleLogFile_Click);
            // 
            // treeView_fields
            // 
            this.treeView_fields.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView_fields.FullRowSelect = true;
            this.treeView_fields.Location = new System.Drawing.Point(8, 3);
            this.treeView_fields.Margin = new System.Windows.Forms.Padding(8, 3, 3, 3);
            this.treeView_fields.Name = "treeView_fields";
            this.treeView_fields.Size = new System.Drawing.Size(270, 231);
            this.treeView_fields.TabIndex = 2;
            this.treeView_fields.TriStateStyleProperty = WebtrendsLogFilePro.TriStateTreeView.TriStateStyles.Installer;
            // 
            // LogFileProForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 400);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LogFileProForm";
            this.Text = "Webtrends Log File Pro";
            this.Load += new System.EventHandler(this.LogFileProForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.grp_statistics.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.grp_outputConfig.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel8.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel3;
        private Button btn_close;
        private Button btn_start;
        private Button btn_help;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel5;
        private GroupBox grp_outputConfig;
        private TableLayoutPanel tableLayoutPanel6;
        private Label lbl_outputTypeTitle;
        private Label lbl_outputFileName;
        private TextBox textBox1;
        private ComboBox cmb_outputFormat;
        private GroupBox grp_statistics;
        private TableLayoutPanel tableLayoutPanel7;
        private Label lbl_totalParsedRows;
        private Label lbl_elapsedTimeTitle;
        private Label lbl_totalRowsTitle;
        private Label lbl_totalRowsValue;
        private Label lbl_totalHeadersValue;
        private TableLayoutPanel tableLayoutPanel8;
        private TriStateTreeView treeView_fields;
        private Label lbl_elapsedTimeValue;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btn_singleLogFile;
        private TextBox txt_singleLogFile;
        private Button btn_gzFileDirectory;
        private Button button2;
        private TextBox txt_gzFileDirectory;
        private TextBox txt_sevenZip;
        private Button btn_extractLogFiles;
        private Button btn_submitSingleLogFile;
    }
}

