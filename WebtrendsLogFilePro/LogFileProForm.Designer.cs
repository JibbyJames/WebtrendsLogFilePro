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
            if (disposing && (components != null)) {
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
            this.grp_Statistics = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_FileSize = new System.Windows.Forms.Label();
            this.lbl_QueryParams = new System.Windows.Forms.Label();
            this.lbl_totalRowsTitle = new System.Windows.Forms.Label();
            this.lbl_TotalRowsValue = new System.Windows.Forms.Label();
            this.lbl_FileSizeValue = new System.Windows.Forms.Label();
            this.lbl_QueryParamsValue = new System.Windows.Forms.Label();
            this.grp_OutputConfig = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_outputFileName = new System.Windows.Forms.Label();
            this.txt_OutputFilename = new System.Windows.Forms.TextBox();
            this.cmb_outputFormat = new System.Windows.Forms.ComboBox();
            this.lbl_outputTypeTitle = new System.Windows.Forms.Label();
            this.lbl_Decode = new System.Windows.Forms.Label();
            this.rdio_Decode_0 = new System.Windows.Forms.RadioButton();
            this.lbl_outputDir = new System.Windows.Forms.Label();
            this.txt_outputDir = new System.Windows.Forms.TextBox();
            this.rdio_Decode_2 = new System.Windows.Forms.RadioButton();
            this.rdio_Decode_1 = new System.Windows.Forms.RadioButton();
            this.btn_outputDir = new System.Windows.Forms.Button();
            this.lbl_Quotes = new System.Windows.Forms.Label();
            this.chk_Quotes = new System.Windows.Forms.CheckBox();
            this.grp_ParseProgress = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_openFile = new System.Windows.Forms.Label();
            this.lbl_Completion = new System.Windows.Forms.Label();
            this.lbl_TimeElapsed = new System.Windows.Forms.Label();
            this.lbl_ParsedRows = new System.Windows.Forms.Label();
            this.lbl_ParsedRowsValue = new System.Windows.Forms.Label();
            this.lbl_TimeElapsedValue = new System.Windows.Forms.Label();
            this.lbl_CompletionValue = new System.Windows.Forms.Label();
            this.btn_Excel = new System.Windows.Forms.Button();
            this.btn_Explorer = new System.Windows.Forms.Button();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.treeView_fields = new WebtrendsLogFilePro.TriStateTreeView();
            this.grp_AddQueryParams = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_addParamsManual = new System.Windows.Forms.Label();
            this.lbl_addParamsScan = new System.Windows.Forms.Label();
            this.btn_QuickScan = new System.Windows.Forms.Button();
            this.btn_FullScan = new System.Windows.Forms.Button();
            this.txt_AddQueryParams = new System.Windows.Forms.TextBox();
            this.btn_AddQueryParams = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_GzFileDirectory = new System.Windows.Forms.Button();
            this.btn_singleLogFile = new System.Windows.Forms.Button();
            this.txt_SingleLogFile = new System.Windows.Forms.TextBox();
            this.btn_SevenZip = new System.Windows.Forms.Button();
            this.txt_GzFileDirectory = new System.Windows.Forms.TextBox();
            this.txt_SevenZipFile = new System.Windows.Forms.TextBox();
            this.btn_ExtractLogFiles = new System.Windows.Forms.Button();
            this.btn_submitSingleLogFile = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.grp_Statistics.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.grp_OutputConfig.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.grp_ParseProgress.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.grp_AddQueryParams.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
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
            this.tableLayoutPanel1.MinimumSize = new System.Drawing.Size(593, 425);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 4F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(636, 578);
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
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 541);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(630, 34);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // btn_help
            // 
            this.btn_help.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_help.Location = new System.Drawing.Point(10, 6);
            this.btn_help.Margin = new System.Windows.Forms.Padding(10, 0, 5, 0);
            this.btn_help.Name = "btn_help";
            this.btn_help.Size = new System.Drawing.Size(25, 22);
            this.btn_help.TabIndex = 22;
            this.btn_help.Text = "?";
            this.btn_help.UseVisualStyleBackColor = true;
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_close.Location = new System.Drawing.Point(500, 6);
            this.btn_close.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(120, 22);
            this.btn_close.TabIndex = 24;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_start
            // 
            this.btn_start.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_start.Location = new System.Drawing.Point(360, 6);
            this.btn_start.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(120, 22);
            this.btn_start.TabIndex = 23;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 315F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel8, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 117);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(630, 418);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.grp_Statistics, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.grp_OutputConfig, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.grp_ParseProgress, 0, 2);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(318, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 3;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 165F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(309, 412);
            this.tableLayoutPanel5.TabIndex = 6;
            // 
            // grp_Statistics
            // 
            this.grp_Statistics.Controls.Add(this.tableLayoutPanel7);
            this.grp_Statistics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grp_Statistics.Location = new System.Drawing.Point(3, 3);
            this.grp_Statistics.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.grp_Statistics.Name = "grp_Statistics";
            this.grp_Statistics.Size = new System.Drawing.Size(296, 104);
            this.grp_Statistics.TabIndex = 7;
            this.grp_Statistics.TabStop = false;
            this.grp_Statistics.Text = "Log File Statistics";
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 86F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Controls.Add(this.lbl_FileSize, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.lbl_QueryParams, 0, 2);
            this.tableLayoutPanel7.Controls.Add(this.lbl_totalRowsTitle, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.lbl_TotalRowsValue, 1, 0);
            this.tableLayoutPanel7.Controls.Add(this.lbl_FileSizeValue, 1, 1);
            this.tableLayoutPanel7.Controls.Add(this.lbl_QueryParamsValue, 1, 2);
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 15);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 3;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(290, 84);
            this.tableLayoutPanel7.TabIndex = 3;
            // 
            // lbl_FileSize
            // 
            this.lbl_FileSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_FileSize.AutoSize = true;
            this.lbl_FileSize.Location = new System.Drawing.Point(3, 35);
            this.lbl_FileSize.Name = "lbl_FileSize";
            this.lbl_FileSize.Size = new System.Drawing.Size(80, 13);
            this.lbl_FileSize.TabIndex = 1;
            this.lbl_FileSize.Text = "File Size (MB):";
            // 
            // lbl_QueryParams
            // 
            this.lbl_QueryParams.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_QueryParams.AutoSize = true;
            this.lbl_QueryParams.Location = new System.Drawing.Point(3, 63);
            this.lbl_QueryParams.Name = "lbl_QueryParams";
            this.lbl_QueryParams.Size = new System.Drawing.Size(80, 13);
            this.lbl_QueryParams.TabIndex = 3;
            this.lbl_QueryParams.Text = "Query Params:";
            // 
            // lbl_totalRowsTitle
            // 
            this.lbl_totalRowsTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_totalRowsTitle.AutoSize = true;
            this.lbl_totalRowsTitle.Location = new System.Drawing.Point(3, 7);
            this.lbl_totalRowsTitle.Name = "lbl_totalRowsTitle";
            this.lbl_totalRowsTitle.Size = new System.Drawing.Size(80, 13);
            this.lbl_totalRowsTitle.TabIndex = 0;
            this.lbl_totalRowsTitle.Text = "Total Rows:";
            // 
            // lbl_TotalRowsValue
            // 
            this.lbl_TotalRowsValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_TotalRowsValue.AutoSize = true;
            this.lbl_TotalRowsValue.Location = new System.Drawing.Point(89, 7);
            this.lbl_TotalRowsValue.Name = "lbl_TotalRowsValue";
            this.lbl_TotalRowsValue.Size = new System.Drawing.Size(198, 13);
            this.lbl_TotalRowsValue.TabIndex = 4;
            this.lbl_TotalRowsValue.Text = "0";
            this.lbl_TotalRowsValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_FileSizeValue
            // 
            this.lbl_FileSizeValue.AutoSize = true;
            this.lbl_FileSizeValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_FileSizeValue.Location = new System.Drawing.Point(89, 28);
            this.lbl_FileSizeValue.Name = "lbl_FileSizeValue";
            this.lbl_FileSizeValue.Size = new System.Drawing.Size(198, 28);
            this.lbl_FileSizeValue.TabIndex = 5;
            this.lbl_FileSizeValue.Text = "0";
            this.lbl_FileSizeValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_QueryParamsValue
            // 
            this.lbl_QueryParamsValue.AutoSize = true;
            this.lbl_QueryParamsValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_QueryParamsValue.Location = new System.Drawing.Point(89, 56);
            this.lbl_QueryParamsValue.Name = "lbl_QueryParamsValue";
            this.lbl_QueryParamsValue.Size = new System.Drawing.Size(198, 28);
            this.lbl_QueryParamsValue.TabIndex = 7;
            this.lbl_QueryParamsValue.Text = "0";
            this.lbl_QueryParamsValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grp_OutputConfig
            // 
            this.grp_OutputConfig.Controls.Add(this.tableLayoutPanel6);
            this.grp_OutputConfig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grp_OutputConfig.Location = new System.Drawing.Point(3, 113);
            this.grp_OutputConfig.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.grp_OutputConfig.Name = "grp_OutputConfig";
            this.grp_OutputConfig.Padding = new System.Windows.Forms.Padding(3, 3, 1, 3);
            this.grp_OutputConfig.Size = new System.Drawing.Size(296, 159);
            this.grp_OutputConfig.TabIndex = 8;
            this.grp_OutputConfig.TabStop = false;
            this.grp_OutputConfig.Text = "Output Config";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel6.ColumnCount = 7;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 87F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.6675F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.6675F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.6675F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66583F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66583F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66583F));
            this.tableLayoutPanel6.Controls.Add(this.lbl_outputFileName, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.txt_OutputFilename, 1, 1);
            this.tableLayoutPanel6.Controls.Add(this.cmb_outputFormat, 1, 2);
            this.tableLayoutPanel6.Controls.Add(this.lbl_outputTypeTitle, 0, 2);
            this.tableLayoutPanel6.Controls.Add(this.lbl_Decode, 0, 3);
            this.tableLayoutPanel6.Controls.Add(this.rdio_Decode_0, 1, 3);
            this.tableLayoutPanel6.Controls.Add(this.lbl_outputDir, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.txt_outputDir, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.rdio_Decode_2, 5, 3);
            this.tableLayoutPanel6.Controls.Add(this.rdio_Decode_1, 3, 3);
            this.tableLayoutPanel6.Controls.Add(this.btn_outputDir, 6, 0);
            this.tableLayoutPanel6.Controls.Add(this.lbl_Quotes, 0, 4);
            this.tableLayoutPanel6.Controls.Add(this.chk_Quotes, 1, 4);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 15);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 5;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.99917F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.00117F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.00117F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.9985F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(291, 140);
            this.tableLayoutPanel6.TabIndex = 5;
            // 
            // lbl_outputFileName
            // 
            this.lbl_outputFileName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_outputFileName.AutoSize = true;
            this.lbl_outputFileName.Location = new System.Drawing.Point(3, 34);
            this.lbl_outputFileName.Name = "lbl_outputFileName";
            this.lbl_outputFileName.Size = new System.Drawing.Size(81, 13);
            this.lbl_outputFileName.TabIndex = 0;
            this.lbl_outputFileName.Text = "Filename:";
            // 
            // txt_OutputFilename
            // 
            this.txt_OutputFilename.AcceptsReturn = true;
            this.txt_OutputFilename.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel6.SetColumnSpan(this.txt_OutputFilename, 6);
            this.txt_OutputFilename.Location = new System.Drawing.Point(87, 31);
            this.txt_OutputFilename.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.txt_OutputFilename.Name = "txt_OutputFilename";
            this.txt_OutputFilename.Size = new System.Drawing.Size(199, 20);
            this.txt_OutputFilename.TabIndex = 11;
            this.txt_OutputFilename.Text = "single-tab-file";
            // 
            // cmb_outputFormat
            // 
            this.cmb_outputFormat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel6.SetColumnSpan(this.cmb_outputFormat, 6);
            this.cmb_outputFormat.DisplayMember = "csv";
            this.cmb_outputFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_outputFormat.FormattingEnabled = true;
            this.cmb_outputFormat.Location = new System.Drawing.Point(87, 58);
            this.cmb_outputFormat.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.cmb_outputFormat.Name = "cmb_outputFormat";
            this.cmb_outputFormat.Size = new System.Drawing.Size(199, 21);
            this.cmb_outputFormat.TabIndex = 12;
            // 
            // lbl_outputTypeTitle
            // 
            this.lbl_outputTypeTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_outputTypeTitle.AutoSize = true;
            this.lbl_outputTypeTitle.Location = new System.Drawing.Point(3, 62);
            this.lbl_outputTypeTitle.Name = "lbl_outputTypeTitle";
            this.lbl_outputTypeTitle.Size = new System.Drawing.Size(81, 13);
            this.lbl_outputTypeTitle.TabIndex = 1;
            this.lbl_outputTypeTitle.Text = "Format:";
            // 
            // lbl_Decode
            // 
            this.lbl_Decode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Decode.AutoSize = true;
            this.lbl_Decode.Location = new System.Drawing.Point(3, 90);
            this.lbl_Decode.Name = "lbl_Decode";
            this.lbl_Decode.Size = new System.Drawing.Size(81, 13);
            this.lbl_Decode.TabIndex = 10;
            this.lbl_Decode.Text = "Decode:";
            // 
            // rdio_Decode_0
            // 
            this.rdio_Decode_0.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rdio_Decode_0.AutoSize = true;
            this.rdio_Decode_0.Checked = true;
            this.tableLayoutPanel6.SetColumnSpan(this.rdio_Decode_0, 2);
            this.rdio_Decode_0.Location = new System.Drawing.Point(90, 88);
            this.rdio_Decode_0.Name = "rdio_Decode_0";
            this.rdio_Decode_0.Size = new System.Drawing.Size(51, 17);
            this.rdio_Decode_0.TabIndex = 13;
            this.rdio_Decode_0.TabStop = true;
            this.rdio_Decode_0.Text = "None";
            this.rdio_Decode_0.UseVisualStyleBackColor = true;
            this.rdio_Decode_0.CheckedChanged += new System.EventHandler(this.rdio_Decode_CheckedChanged);
            // 
            // lbl_outputDir
            // 
            this.lbl_outputDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_outputDir.AutoSize = true;
            this.lbl_outputDir.Location = new System.Drawing.Point(3, 7);
            this.lbl_outputDir.Name = "lbl_outputDir";
            this.lbl_outputDir.Size = new System.Drawing.Size(81, 13);
            this.lbl_outputDir.TabIndex = 17;
            this.lbl_outputDir.Text = "Directory:";
            // 
            // txt_outputDir
            // 
            this.txt_outputDir.AcceptsReturn = true;
            this.txt_outputDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel6.SetColumnSpan(this.txt_outputDir, 5);
            this.txt_outputDir.Location = new System.Drawing.Point(87, 3);
            this.txt_outputDir.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.txt_outputDir.Name = "txt_outputDir";
            this.txt_outputDir.Size = new System.Drawing.Size(165, 20);
            this.txt_outputDir.TabIndex = 9;
            // 
            // rdio_Decode_2
            // 
            this.rdio_Decode_2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rdio_Decode_2.AutoSize = true;
            this.tableLayoutPanel6.SetColumnSpan(this.rdio_Decode_2, 2);
            this.rdio_Decode_2.Location = new System.Drawing.Point(225, 88);
            this.rdio_Decode_2.Name = "rdio_Decode_2";
            this.rdio_Decode_2.Size = new System.Drawing.Size(54, 17);
            this.rdio_Decode_2.TabIndex = 15;
            this.rdio_Decode_2.Text = "Twice";
            this.rdio_Decode_2.UseVisualStyleBackColor = true;
            this.rdio_Decode_2.CheckedChanged += new System.EventHandler(this.rdio_Decode_CheckedChanged);
            // 
            // rdio_Decode_1
            // 
            this.rdio_Decode_1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rdio_Decode_1.AutoSize = true;
            this.tableLayoutPanel6.SetColumnSpan(this.rdio_Decode_1, 2);
            this.rdio_Decode_1.Location = new System.Drawing.Point(158, 88);
            this.rdio_Decode_1.Name = "rdio_Decode_1";
            this.rdio_Decode_1.Size = new System.Drawing.Size(51, 17);
            this.rdio_Decode_1.TabIndex = 14;
            this.rdio_Decode_1.Text = "Once";
            this.rdio_Decode_1.UseVisualStyleBackColor = true;
            this.rdio_Decode_1.CheckedChanged += new System.EventHandler(this.rdio_Decode_CheckedChanged);
            // 
            // btn_outputDir
            // 
            this.btn_outputDir.Location = new System.Drawing.Point(256, 2);
            this.btn_outputDir.Margin = new System.Windows.Forms.Padding(1, 2, 3, 3);
            this.btn_outputDir.Name = "btn_outputDir";
            this.btn_outputDir.Size = new System.Drawing.Size(30, 22);
            this.btn_outputDir.TabIndex = 10;
            this.btn_outputDir.Text = "📂";
            this.btn_outputDir.UseVisualStyleBackColor = true;
            this.btn_outputDir.Click += new System.EventHandler(this.btn_outputDir_Click);
            // 
            // lbl_Quotes
            // 
            this.lbl_Quotes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Quotes.AutoSize = true;
            this.lbl_Quotes.Location = new System.Drawing.Point(3, 118);
            this.lbl_Quotes.Name = "lbl_Quotes";
            this.lbl_Quotes.Size = new System.Drawing.Size(81, 13);
            this.lbl_Quotes.TabIndex = 18;
            this.lbl_Quotes.Text = "Quotes:";
            // 
            // chk_Quotes
            // 
            this.chk_Quotes.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chk_Quotes.AutoSize = true;
            this.tableLayoutPanel6.SetColumnSpan(this.chk_Quotes, 3);
            this.chk_Quotes.Location = new System.Drawing.Point(90, 117);
            this.chk_Quotes.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.chk_Quotes.Name = "chk_Quotes";
            this.chk_Quotes.Size = new System.Drawing.Size(65, 17);
            this.chk_Quotes.TabIndex = 19;
            this.chk_Quotes.Text = "Enabled";
            this.chk_Quotes.UseVisualStyleBackColor = true;
            this.chk_Quotes.CheckedChanged += new System.EventHandler(this.chk_Quotes_CheckedChanged);
            // 
            // grp_ParseProgress
            // 
            this.grp_ParseProgress.Controls.Add(this.tableLayoutPanel10);
            this.grp_ParseProgress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grp_ParseProgress.Location = new System.Drawing.Point(3, 278);
            this.grp_ParseProgress.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.grp_ParseProgress.Name = "grp_ParseProgress";
            this.grp_ParseProgress.Size = new System.Drawing.Size(296, 131);
            this.grp_ParseProgress.TabIndex = 9;
            this.grp_ParseProgress.TabStop = false;
            this.grp_ParseProgress.Text = "Progress";
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.ColumnCount = 3;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 87F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.Controls.Add(this.lbl_openFile, 0, 3);
            this.tableLayoutPanel10.Controls.Add(this.lbl_Completion, 0, 2);
            this.tableLayoutPanel10.Controls.Add(this.lbl_TimeElapsed, 0, 1);
            this.tableLayoutPanel10.Controls.Add(this.lbl_ParsedRows, 0, 0);
            this.tableLayoutPanel10.Controls.Add(this.lbl_ParsedRowsValue, 1, 0);
            this.tableLayoutPanel10.Controls.Add(this.lbl_TimeElapsedValue, 1, 1);
            this.tableLayoutPanel10.Controls.Add(this.lbl_CompletionValue, 1, 2);
            this.tableLayoutPanel10.Controls.Add(this.btn_Excel, 1, 3);
            this.tableLayoutPanel10.Controls.Add(this.btn_Explorer, 2, 3);
            this.tableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel10.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 4;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.99813F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(290, 112);
            this.tableLayoutPanel10.TabIndex = 0;
            // 
            // lbl_openFile
            // 
            this.lbl_openFile.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_openFile.AutoSize = true;
            this.lbl_openFile.Location = new System.Drawing.Point(3, 91);
            this.lbl_openFile.Name = "lbl_openFile";
            this.lbl_openFile.Size = new System.Drawing.Size(55, 13);
            this.lbl_openFile.TabIndex = 15;
            this.lbl_openFile.Text = "Open File:";
            // 
            // lbl_Completion
            // 
            this.lbl_Completion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_Completion.AutoSize = true;
            this.lbl_Completion.Location = new System.Drawing.Point(3, 63);
            this.lbl_Completion.Name = "lbl_Completion";
            this.lbl_Completion.Size = new System.Drawing.Size(62, 13);
            this.lbl_Completion.TabIndex = 11;
            this.lbl_Completion.Text = "Completion:";
            // 
            // lbl_TimeElapsed
            // 
            this.lbl_TimeElapsed.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_TimeElapsed.AutoSize = true;
            this.lbl_TimeElapsed.Location = new System.Drawing.Point(3, 35);
            this.lbl_TimeElapsed.Name = "lbl_TimeElapsed";
            this.lbl_TimeElapsed.Size = new System.Drawing.Size(74, 13);
            this.lbl_TimeElapsed.TabIndex = 10;
            this.lbl_TimeElapsed.Text = "Time Elapsed:";
            // 
            // lbl_ParsedRows
            // 
            this.lbl_ParsedRows.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_ParsedRows.AutoSize = true;
            this.lbl_ParsedRows.Location = new System.Drawing.Point(3, 7);
            this.lbl_ParsedRows.Name = "lbl_ParsedRows";
            this.lbl_ParsedRows.Size = new System.Drawing.Size(73, 13);
            this.lbl_ParsedRows.TabIndex = 9;
            this.lbl_ParsedRows.Text = "Parsed Rows:";
            // 
            // lbl_ParsedRowsValue
            // 
            this.lbl_ParsedRowsValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_ParsedRowsValue.AutoSize = true;
            this.lbl_ParsedRowsValue.Location = new System.Drawing.Point(90, 7);
            this.lbl_ParsedRowsValue.Name = "lbl_ParsedRowsValue";
            this.lbl_ParsedRowsValue.Size = new System.Drawing.Size(95, 13);
            this.lbl_ParsedRowsValue.TabIndex = 12;
            this.lbl_ParsedRowsValue.Text = "0";
            // 
            // lbl_TimeElapsedValue
            // 
            this.lbl_TimeElapsedValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_TimeElapsedValue.AutoSize = true;
            this.lbl_TimeElapsedValue.Location = new System.Drawing.Point(90, 35);
            this.lbl_TimeElapsedValue.Name = "lbl_TimeElapsedValue";
            this.lbl_TimeElapsedValue.Size = new System.Drawing.Size(49, 13);
            this.lbl_TimeElapsedValue.TabIndex = 13;
            this.lbl_TimeElapsedValue.Text = "00:00:00";
            // 
            // lbl_CompletionValue
            // 
            this.lbl_CompletionValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_CompletionValue.AutoSize = true;
            this.lbl_CompletionValue.Location = new System.Drawing.Point(90, 63);
            this.lbl_CompletionValue.Name = "lbl_CompletionValue";
            this.lbl_CompletionValue.Size = new System.Drawing.Size(95, 13);
            this.lbl_CompletionValue.TabIndex = 14;
            this.lbl_CompletionValue.Text = "0%";
            // 
            // btn_Excel
            // 
            this.btn_Excel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Excel.Location = new System.Drawing.Point(90, 87);
            this.btn_Excel.Name = "btn_Excel";
            this.btn_Excel.Size = new System.Drawing.Size(95, 22);
            this.btn_Excel.TabIndex = 20;
            this.btn_Excel.Text = "Excel";
            this.btn_Excel.UseVisualStyleBackColor = true;
            this.btn_Excel.Click += new System.EventHandler(this.btn_Excel_Click);
            // 
            // btn_Explorer
            // 
            this.btn_Explorer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Explorer.Location = new System.Drawing.Point(191, 87);
            this.btn_Explorer.Name = "btn_Explorer";
            this.btn_Explorer.Size = new System.Drawing.Size(96, 22);
            this.btn_Explorer.TabIndex = 21;
            this.btn_Explorer.Text = "Explorer";
            this.btn_Explorer.UseVisualStyleBackColor = true;
            this.btn_Explorer.Click += new System.EventHandler(this.btn_Explorer_Click);
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 1;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.Controls.Add(this.treeView_fields, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.grp_AddQueryParams, 0, 1);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel8.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 2;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(309, 415);
            this.tableLayoutPanel8.TabIndex = 7;
            // 
            // treeView_fields
            // 
            this.treeView_fields.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView_fields.FullRowSelect = true;
            this.treeView_fields.Location = new System.Drawing.Point(8, 3);
            this.treeView_fields.Margin = new System.Windows.Forms.Padding(8, 3, 3, 3);
            this.treeView_fields.Name = "treeView_fields";
            this.treeView_fields.Size = new System.Drawing.Size(298, 325);
            this.treeView_fields.TabIndex = 8;
            this.treeView_fields.TriStateStyleProperty = WebtrendsLogFilePro.TriStateTreeView.TriStateStyles.Installer;
            this.treeView_fields.KeyDown += new System.Windows.Forms.KeyEventHandler(this.treeView_fields_KeyPress);
            // 
            // grp_AddQueryParams
            // 
            this.grp_AddQueryParams.Controls.Add(this.tableLayoutPanel9);
            this.grp_AddQueryParams.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grp_AddQueryParams.Location = new System.Drawing.Point(5, 334);
            this.grp_AddQueryParams.Margin = new System.Windows.Forms.Padding(5, 3, 3, 6);
            this.grp_AddQueryParams.Name = "grp_AddQueryParams";
            this.grp_AddQueryParams.Size = new System.Drawing.Size(301, 75);
            this.grp_AddQueryParams.TabIndex = 3;
            this.grp_AddQueryParams.TabStop = false;
            this.grp_AddQueryParams.Text = "Add Query Parameters";
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 7;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel9.Controls.Add(this.lbl_addParamsManual, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.lbl_addParamsScan, 0, 1);
            this.tableLayoutPanel9.Controls.Add(this.btn_QuickScan, 1, 1);
            this.tableLayoutPanel9.Controls.Add(this.btn_FullScan, 4, 1);
            this.tableLayoutPanel9.Controls.Add(this.txt_AddQueryParams, 1, 0);
            this.tableLayoutPanel9.Controls.Add(this.btn_AddQueryParams, 6, 0);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 2;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(295, 56);
            this.tableLayoutPanel9.TabIndex = 0;
            // 
            // lbl_addParamsManual
            // 
            this.lbl_addParamsManual.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_addParamsManual.AutoSize = true;
            this.lbl_addParamsManual.Location = new System.Drawing.Point(3, 7);
            this.lbl_addParamsManual.Name = "lbl_addParamsManual";
            this.lbl_addParamsManual.Size = new System.Drawing.Size(98, 13);
            this.lbl_addParamsManual.TabIndex = 0;
            this.lbl_addParamsManual.Text = "Type Params Here:";
            // 
            // lbl_addParamsScan
            // 
            this.lbl_addParamsScan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_addParamsScan.AutoSize = true;
            this.lbl_addParamsScan.Location = new System.Drawing.Point(3, 35);
            this.lbl_addParamsScan.Name = "lbl_addParamsScan";
            this.lbl_addParamsScan.Size = new System.Drawing.Size(98, 13);
            this.lbl_addParamsScan.TabIndex = 1;
            this.lbl_addParamsScan.Text = "Scan Log File:";
            this.lbl_addParamsScan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_QuickScan
            // 
            this.tableLayoutPanel9.SetColumnSpan(this.btn_QuickScan, 3);
            this.btn_QuickScan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_QuickScan.Location = new System.Drawing.Point(107, 31);
            this.btn_QuickScan.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.btn_QuickScan.Name = "btn_QuickScan";
            this.btn_QuickScan.Size = new System.Drawing.Size(93, 22);
            this.btn_QuickScan.TabIndex = 18;
            this.btn_QuickScan.Text = "Quick";
            this.btn_QuickScan.UseVisualStyleBackColor = true;
            this.btn_QuickScan.Click += new System.EventHandler(this.btn_QuickScan_Click);
            // 
            // btn_FullScan
            // 
            this.tableLayoutPanel9.SetColumnSpan(this.btn_FullScan, 3);
            this.btn_FullScan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_FullScan.Location = new System.Drawing.Point(203, 31);
            this.btn_FullScan.Name = "btn_FullScan";
            this.btn_FullScan.Size = new System.Drawing.Size(89, 22);
            this.btn_FullScan.TabIndex = 19;
            this.btn_FullScan.Text = "Full";
            this.btn_FullScan.UseVisualStyleBackColor = true;
            this.btn_FullScan.Click += new System.EventHandler(this.btn_FullScan_Click);
            // 
            // txt_AddQueryParams
            // 
            this.txt_AddQueryParams.AcceptsReturn = true;
            this.tableLayoutPanel9.SetColumnSpan(this.txt_AddQueryParams, 5);
            this.txt_AddQueryParams.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_AddQueryParams.Location = new System.Drawing.Point(107, 4);
            this.txt_AddQueryParams.Margin = new System.Windows.Forms.Padding(3, 4, 3, 3);
            this.txt_AddQueryParams.Name = "txt_AddQueryParams";
            this.txt_AddQueryParams.Size = new System.Drawing.Size(152, 20);
            this.txt_AddQueryParams.TabIndex = 16;
            this.txt_AddQueryParams.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_AddQueryParams_KeyDown);
            // 
            // btn_AddQueryParams
            // 
            this.btn_AddQueryParams.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_AddQueryParams.Location = new System.Drawing.Point(263, 3);
            this.btn_AddQueryParams.Margin = new System.Windows.Forms.Padding(1, 3, 3, 3);
            this.btn_AddQueryParams.Name = "btn_AddQueryParams";
            this.btn_AddQueryParams.Size = new System.Drawing.Size(29, 22);
            this.btn_AddQueryParams.TabIndex = 17;
            this.btn_AddQueryParams.Text = "✓";
            this.btn_AddQueryParams.UseVisualStyleBackColor = true;
            this.btn_AddQueryParams.Click += new System.EventHandler(this.btn_AddQueryParams_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(14, 7);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(14, 3, 16, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(606, 104);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input Config";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel2.Controls.Add(this.btn_GzFileDirectory, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_singleLogFile, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.txt_SingleLogFile, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.btn_SevenZip, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.txt_GzFileDirectory, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.txt_SevenZipFile, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.btn_ExtractLogFiles, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_submitSingleLogFile, 2, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33332F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(600, 85);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // btn_GzFileDirectory
            // 
            this.btn_GzFileDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_GzFileDirectory.Location = new System.Drawing.Point(3, 3);
            this.btn_GzFileDirectory.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btn_GzFileDirectory.Name = "btn_GzFileDirectory";
            this.btn_GzFileDirectory.Size = new System.Drawing.Size(117, 22);
            this.btn_GzFileDirectory.TabIndex = 0;
            this.btn_GzFileDirectory.Text = "Gz Files Directory";
            this.btn_GzFileDirectory.UseVisualStyleBackColor = true;
            this.btn_GzFileDirectory.Click += new System.EventHandler(this.btn_GzFileDirectory_Click);
            // 
            // btn_singleLogFile
            // 
            this.btn_singleLogFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_singleLogFile.Location = new System.Drawing.Point(3, 59);
            this.btn_singleLogFile.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btn_singleLogFile.Name = "btn_singleLogFile";
            this.btn_singleLogFile.Size = new System.Drawing.Size(117, 22);
            this.btn_singleLogFile.TabIndex = 5;
            this.btn_singleLogFile.Text = "Single Log File";
            this.btn_singleLogFile.UseVisualStyleBackColor = true;
            this.btn_singleLogFile.Click += new System.EventHandler(this.btn_SingleLogFile_Click);
            // 
            // txt_SingleLogFile
            // 
            this.txt_SingleLogFile.AcceptsReturn = true;
            this.txt_SingleLogFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_SingleLogFile.Location = new System.Drawing.Point(124, 60);
            this.txt_SingleLogFile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_SingleLogFile.Name = "txt_SingleLogFile";
            this.txt_SingleLogFile.Size = new System.Drawing.Size(352, 20);
            this.txt_SingleLogFile.TabIndex = 6;
            // 
            // btn_SevenZip
            // 
            this.btn_SevenZip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_SevenZip.Location = new System.Drawing.Point(3, 31);
            this.btn_SevenZip.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btn_SevenZip.Name = "btn_SevenZip";
            this.btn_SevenZip.Size = new System.Drawing.Size(117, 22);
            this.btn_SevenZip.TabIndex = 3;
            this.btn_SevenZip.Text = "7z.exe Location";
            this.btn_SevenZip.UseVisualStyleBackColor = true;
            this.btn_SevenZip.Click += new System.EventHandler(this.btn_SevenZip_Click);
            // 
            // txt_GzFileDirectory
            // 
            this.txt_GzFileDirectory.AcceptsReturn = true;
            this.txt_GzFileDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_GzFileDirectory.Location = new System.Drawing.Point(124, 4);
            this.txt_GzFileDirectory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_GzFileDirectory.Name = "txt_GzFileDirectory";
            this.txt_GzFileDirectory.Size = new System.Drawing.Size(352, 20);
            this.txt_GzFileDirectory.TabIndex = 1;
            // 
            // txt_SevenZipFile
            // 
            this.txt_SevenZipFile.AcceptsReturn = true;
            this.txt_SevenZipFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_SevenZipFile.Location = new System.Drawing.Point(124, 32);
            this.txt_SevenZipFile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_SevenZipFile.Name = "txt_SevenZipFile";
            this.txt_SevenZipFile.Size = new System.Drawing.Size(352, 20);
            this.txt_SevenZipFile.TabIndex = 4;
            this.txt_SevenZipFile.Text = "C:\\Program Files\\7-Zip\\7z.exe";
            // 
            // btn_ExtractLogFiles
            // 
            this.btn_ExtractLogFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_ExtractLogFiles.Location = new System.Drawing.Point(480, 3);
            this.btn_ExtractLogFiles.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.btn_ExtractLogFiles.Name = "btn_ExtractLogFiles";
            this.tableLayoutPanel2.SetRowSpan(this.btn_ExtractLogFiles, 2);
            this.btn_ExtractLogFiles.Size = new System.Drawing.Size(117, 50);
            this.btn_ExtractLogFiles.TabIndex = 2;
            this.btn_ExtractLogFiles.Text = "Extract";
            this.btn_ExtractLogFiles.UseVisualStyleBackColor = true;
            this.btn_ExtractLogFiles.Click += new System.EventHandler(this.btn_ExtractLogFiles_Click);
            // 
            // btn_submitSingleLogFile
            // 
            this.btn_submitSingleLogFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_submitSingleLogFile.Location = new System.Drawing.Point(480, 59);
            this.btn_submitSingleLogFile.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.btn_submitSingleLogFile.Name = "btn_submitSingleLogFile";
            this.btn_submitSingleLogFile.Size = new System.Drawing.Size(117, 22);
            this.btn_submitSingleLogFile.TabIndex = 7;
            this.btn_submitSingleLogFile.Text = "Submit";
            this.btn_submitSingleLogFile.UseVisualStyleBackColor = true;
            this.btn_submitSingleLogFile.Click += new System.EventHandler(this.btn_SubmitSingleLogFile_Click);
            // 
            // LogFileProForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 578);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LogFileProForm";
            this.Text = "Webtrends Log File Pro";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.grp_Statistics.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.grp_OutputConfig.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.grp_ParseProgress.ResumeLayout(false);
            this.tableLayoutPanel10.ResumeLayout(false);
            this.tableLayoutPanel10.PerformLayout();
            this.tableLayoutPanel8.ResumeLayout(false);
            this.grp_AddQueryParams.ResumeLayout(false);
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel9.PerformLayout();
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
        private TableLayoutPanel tableLayoutPanel8;
        private TriStateTreeView treeView_fields;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btn_singleLogFile;
        private TextBox txt_SingleLogFile;
        private Button btn_GzFileDirectory;
        private Button btn_SevenZip;
        private TextBox txt_GzFileDirectory;
        private TextBox txt_SevenZipFile;
        private Button btn_ExtractLogFiles;
        private Button btn_submitSingleLogFile;
        private GroupBox grp_AddQueryParams;
        private TableLayoutPanel tableLayoutPanel9;
        private Label lbl_addParamsManual;
        private Label lbl_addParamsScan;
        private Button btn_QuickScan;
        private Button btn_FullScan;
        private TextBox txt_AddQueryParams;
        private Button btn_AddQueryParams;
        private GroupBox grp_Statistics;
        private TableLayoutPanel tableLayoutPanel7;
        private Label lbl_FileSize;
        private Label lbl_QueryParams;
        private Label lbl_totalRowsTitle;
        private Label lbl_TotalRowsValue;
        private Label lbl_FileSizeValue;
        private Label lbl_QueryParamsValue;
        private GroupBox grp_OutputConfig;
        private TableLayoutPanel tableLayoutPanel6;
        private RadioButton rdio_Decode_2;
        private RadioButton rdio_Decode_1;
        private Label lbl_outputFileName;
        private TextBox txt_OutputFilename;
        private ComboBox cmb_outputFormat;
        private Label lbl_outputTypeTitle;
        private Label lbl_Decode;
        private RadioButton rdio_Decode_0;
        private GroupBox grp_ParseProgress;
        private TableLayoutPanel tableLayoutPanel10;
        private Label lbl_ParsedRows;
        private Label lbl_Completion;
        private Label lbl_TimeElapsed;
        private Label lbl_ParsedRowsValue;
        private Label lbl_TimeElapsedValue;
        private Label lbl_CompletionValue;
        private Label lbl_openFile;
        private Button btn_Excel;
        private Button btn_Explorer;
        private Label lbl_outputDir;
        private TextBox txt_outputDir;
        private Button btn_outputDir;
        private Label lbl_Quotes;
        private CheckBox chk_Quotes;
    }
}

