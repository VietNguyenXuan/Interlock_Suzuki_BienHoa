using BarcodeUtility;

namespace BarcodeScannerUsbUtility
{
  partial class FormMain
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
      this.barcode_reader = new barcode.BarcodeUC();
      this.timerMqtt = new System.Windows.Forms.Timer(this.components);
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
      this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
      this.lblClock = new System.Windows.Forms.Label();
      this.btnBarCode = new System.Windows.Forms.Button();
      this.btnConnectNetwork = new System.Windows.Forms.Button();
      this.label2 = new System.Windows.Forms.Label();
      this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.btnSetting = new System.Windows.Forms.Button();
      this.btnClear = new System.Windows.Forms.Button();
      this.picExit = new System.Windows.Forms.PictureBox();
      this.picEnlarge = new System.Windows.Forms.PictureBox();
      this.picNomal = new System.Windows.Forms.PictureBox();
      this.picMin = new System.Windows.Forms.PictureBox();
      this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.dgvMode = new System.Windows.Forms.DataGridView();
      this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.txtOutput = new System.Windows.Forms.RichTextBox();
      this.tableLayoutPanel1.SuspendLayout();
      this.tableLayoutPanel2.SuspendLayout();
      this.tableLayoutPanel5.SuspendLayout();
      this.tableLayoutPanel3.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.picEnlarge)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.picNomal)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.picMin)).BeginInit();
      this.tableLayoutPanel7.SuspendLayout();
      this.groupBox2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgvMode)).BeginInit();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // barcode_reader
      // 
      this.barcode_reader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(244)))), ((int)(((byte)(247)))));
      this.barcode_reader.Location = new System.Drawing.Point(93, 268);
      this.barcode_reader.Margin = new System.Windows.Forms.Padding(5);
      this.barcode_reader.Name = "barcode_reader";
      this.barcode_reader.Size = new System.Drawing.Size(101, 31);
      this.barcode_reader.TabIndex = 0;
      this.barcode_reader.Visible = false;
      // 
      // timerMqtt
      // 
      this.timerMqtt.Tick += new System.EventHandler(this.timerMqtt_Tick);
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(47)))));
      this.tableLayoutPanel1.ColumnCount = 3;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
      this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 3;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(1113, 660);
      this.tableLayoutPanel1.TabIndex = 2;
      // 
      // tableLayoutPanel2
      // 
      this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tableLayoutPanel2.ColumnCount = 1;
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel5, 0, 4);
      this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
      this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel7, 0, 2);
      this.tableLayoutPanel2.Location = new System.Drawing.Point(13, 13);
      this.tableLayoutPanel2.Name = "tableLayoutPanel2";
      this.tableLayoutPanel2.RowCount = 5;
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
      this.tableLayoutPanel2.Size = new System.Drawing.Size(1087, 639);
      this.tableLayoutPanel2.TabIndex = 0;
      // 
      // tableLayoutPanel5
      // 
      this.tableLayoutPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tableLayoutPanel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(47)))));
      this.tableLayoutPanel5.ColumnCount = 6;
      this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 320F));
      this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
      this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
      this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 189F));
      this.tableLayoutPanel5.Controls.Add(this.lblClock, 5, 0);
      this.tableLayoutPanel5.Controls.Add(this.btnBarCode, 4, 0);
      this.tableLayoutPanel5.Controls.Add(this.btnConnectNetwork, 2, 0);
      this.tableLayoutPanel5.Controls.Add(this.label2, 0, 0);
      this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 602);
      this.tableLayoutPanel5.Name = "tableLayoutPanel5";
      this.tableLayoutPanel5.RowCount = 1;
      this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel5.Size = new System.Drawing.Size(1081, 34);
      this.tableLayoutPanel5.TabIndex = 8;
      // 
      // lblClock
      // 
      this.lblClock.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.lblClock.AutoSize = true;
      this.lblClock.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblClock.ForeColor = System.Drawing.Color.White;
      this.lblClock.Location = new System.Drawing.Point(895, 0);
      this.lblClock.Name = "lblClock";
      this.lblClock.Size = new System.Drawing.Size(183, 34);
      this.lblClock.TabIndex = 5;
      this.lblClock.Text = "label1";
      this.lblClock.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // btnBarCode
      // 
      this.btnBarCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.btnBarCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.btnBarCode.FlatAppearance.BorderSize = 0;
      this.btnBarCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnBarCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnBarCode.ForeColor = System.Drawing.Color.White;
      this.btnBarCode.Image = ((System.Drawing.Image)(resources.GetObject("btnBarCode.Image")));
      this.btnBarCode.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnBarCode.Location = new System.Drawing.Point(695, 3);
      this.btnBarCode.Name = "btnBarCode";
      this.btnBarCode.Size = new System.Drawing.Size(194, 28);
      this.btnBarCode.TabIndex = 4;
      this.btnBarCode.Text = "  BarcodeScan";
      this.btnBarCode.UseVisualStyleBackColor = false;
      // 
      // btnConnectNetwork
      // 
      this.btnConnectNetwork.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.btnConnectNetwork.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.btnConnectNetwork.FlatAppearance.BorderSize = 0;
      this.btnConnectNetwork.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnConnectNetwork.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnConnectNetwork.ForeColor = System.Drawing.Color.White;
      this.btnConnectNetwork.Image = ((System.Drawing.Image)(resources.GetObject("btnConnectNetwork.Image")));
      this.btnConnectNetwork.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnConnectNetwork.Location = new System.Drawing.Point(475, 3);
      this.btnConnectNetwork.Name = "btnConnectNetwork";
      this.btnConnectNetwork.Size = new System.Drawing.Size(194, 28);
      this.btnConnectNetwork.TabIndex = 3;
      this.btnConnectNetwork.Text = "      Reconnect Network";
      this.btnConnectNetwork.UseVisualStyleBackColor = false;
      this.btnConnectNetwork.Click += new System.EventHandler(this.btnConnectNetwork_Click);
      // 
      // label2
      // 
      this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.label2.AutoSize = true;
      this.label2.ForeColor = System.Drawing.Color.White;
      this.label2.Location = new System.Drawing.Point(3, 0);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(314, 34);
      this.label2.TabIndex = 6;
      this.label2.Text = "Coppyright © 2020 VuleTech. All rights resered.";
      this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // tableLayoutPanel3
      // 
      this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tableLayoutPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(19)))), ((int)(((byte)(45)))));
      this.tableLayoutPanel3.ColumnCount = 12;
      this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 170F));
      this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.66444F));
      this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.16778F));
      this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
      this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.16778F));
      this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
      this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
      this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
      this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 69F));
      this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
      this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
      this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 68F));
      this.tableLayoutPanel3.Controls.Add(this.pictureBox1, 0, 0);
      this.tableLayoutPanel3.Controls.Add(this.btnSetting, 4, 0);
      this.tableLayoutPanel3.Controls.Add(this.btnClear, 2, 0);
      this.tableLayoutPanel3.Controls.Add(this.picExit, 11, 0);
      this.tableLayoutPanel3.Controls.Add(this.picEnlarge, 9, 0);
      this.tableLayoutPanel3.Controls.Add(this.picNomal, 8, 0);
      this.tableLayoutPanel3.Controls.Add(this.picMin, 6, 0);
      this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
      this.tableLayoutPanel3.Name = "tableLayoutPanel3";
      this.tableLayoutPanel3.RowCount = 1;
      this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel3.Size = new System.Drawing.Size(1081, 54);
      this.tableLayoutPanel3.TabIndex = 1;
      // 
      // pictureBox1
      // 
      this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
      this.pictureBox1.Location = new System.Drawing.Point(3, 3);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(164, 48);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pictureBox1.TabIndex = 0;
      this.pictureBox1.TabStop = false;
      // 
      // btnSetting
      // 
      this.btnSetting.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.btnSetting.BackColor = System.Drawing.Color.DodgerBlue;
      this.btnSetting.FlatAppearance.BorderSize = 0;
      this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnSetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnSetting.ForeColor = System.Drawing.Color.White;
      this.btnSetting.Image = ((System.Drawing.Image)(resources.GetObject("btnSetting.Image")));
      this.btnSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnSetting.Location = new System.Drawing.Point(639, 3);
      this.btnSetting.Name = "btnSetting";
      this.btnSetting.Size = new System.Drawing.Size(155, 48);
      this.btnSetting.TabIndex = 2;
      this.btnSetting.Text = "   Setting";
      this.btnSetting.UseVisualStyleBackColor = false;
      this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
      // 
      // btnClear
      // 
      this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(64)))), ((int)(((byte)(139)))));
      this.btnClear.FlatAppearance.BorderSize = 0;
      this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnClear.ForeColor = System.Drawing.Color.White;
      this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
      this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnClear.Location = new System.Drawing.Point(468, 3);
      this.btnClear.Name = "btnClear";
      this.btnClear.Size = new System.Drawing.Size(155, 48);
      this.btnClear.TabIndex = 6;
      this.btnClear.Text = "   Clear";
      this.btnClear.UseVisualStyleBackColor = false;
      this.btnClear.Click += new System.EventHandler(this.btnClear_Click_1);
      // 
      // picExit
      // 
      this.picExit.Image = ((System.Drawing.Image)(resources.GetObject("picExit.Image")));
      this.picExit.Location = new System.Drawing.Point(1014, 3);
      this.picExit.Name = "picExit";
      this.picExit.Size = new System.Drawing.Size(55, 48);
      this.picExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.picExit.TabIndex = 5;
      this.picExit.TabStop = false;
      this.picExit.Click += new System.EventHandler(this.picExit_Click);
      // 
      // picEnlarge
      // 
      this.picEnlarge.Image = ((System.Drawing.Image)(resources.GetObject("picEnlarge.Image")));
      this.picEnlarge.Location = new System.Drawing.Point(949, 3);
      this.picEnlarge.Name = "picEnlarge";
      this.picEnlarge.Size = new System.Drawing.Size(54, 48);
      this.picEnlarge.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.picEnlarge.TabIndex = 7;
      this.picEnlarge.TabStop = false;
      this.picEnlarge.Click += new System.EventHandler(this.picEnlarge_Click);
      // 
      // picNomal
      // 
      this.picNomal.Image = ((System.Drawing.Image)(resources.GetObject("picNomal.Image")));
      this.picNomal.Location = new System.Drawing.Point(880, 3);
      this.picNomal.Name = "picNomal";
      this.picNomal.Size = new System.Drawing.Size(54, 48);
      this.picNomal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.picNomal.TabIndex = 8;
      this.picNomal.TabStop = false;
      this.picNomal.Click += new System.EventHandler(this.picNomal_Click);
      // 
      // picMin
      // 
      this.picMin.Image = ((System.Drawing.Image)(resources.GetObject("picMin.Image")));
      this.picMin.Location = new System.Drawing.Point(810, 3);
      this.picMin.Name = "picMin";
      this.picMin.Size = new System.Drawing.Size(54, 48);
      this.picMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.picMin.TabIndex = 9;
      this.picMin.TabStop = false;
      this.picMin.Click += new System.EventHandler(this.picMin_Click);
      // 
      // tableLayoutPanel7
      // 
      this.tableLayoutPanel7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tableLayoutPanel7.ColumnCount = 2;
      this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.14552F));
      this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.85448F));
      this.tableLayoutPanel7.Controls.Add(this.groupBox2, 0, 0);
      this.tableLayoutPanel7.Controls.Add(this.groupBox1, 1, 0);
      this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 68);
      this.tableLayoutPanel7.Name = "tableLayoutPanel7";
      this.tableLayoutPanel7.RowCount = 1;
      this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel7.Size = new System.Drawing.Size(1081, 523);
      this.tableLayoutPanel7.TabIndex = 7;
      // 
      // groupBox2
      // 
      this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBox2.Controls.Add(this.dgvMode);
      this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.groupBox2.ForeColor = System.Drawing.Color.White;
      this.groupBox2.Location = new System.Drawing.Point(3, 3);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(287, 517);
      this.groupBox2.TabIndex = 4;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Model";
      // 
      // dgvMode
      // 
      dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(22)))), ((int)(((byte)(44)))));
      this.dgvMode.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
      this.dgvMode.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.dgvMode.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(22)))), ((int)(((byte)(44)))));
      dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(22)))), ((int)(((byte)(44)))));
      dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.dgvMode.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
      this.dgvMode.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvMode.ColumnHeadersVisible = false;
      this.dgvMode.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
      dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(22)))), ((int)(((byte)(44)))));
      dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
      dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.dgvMode.DefaultCellStyle = dataGridViewCellStyle3;
      this.dgvMode.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dgvMode.Location = new System.Drawing.Point(3, 26);
      this.dgvMode.Name = "dgvMode";
      this.dgvMode.RowHeadersVisible = false;
      this.dgvMode.RowHeadersWidth = 51;
      this.dgvMode.RowTemplate.Height = 24;
      this.dgvMode.Size = new System.Drawing.Size(281, 488);
      this.dgvMode.TabIndex = 0;
      // 
      // Column1
      // 
      this.Column1.HeaderText = "Column1";
      this.Column1.MinimumWidth = 6;
      this.Column1.Name = "Column1";
      // 
      // groupBox1
      // 
      this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBox1.Controls.Add(this.txtOutput);
      this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.groupBox1.ForeColor = System.Drawing.Color.White;
      this.groupBox1.Location = new System.Drawing.Point(296, 3);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(782, 517);
      this.groupBox1.TabIndex = 3;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Barcode content";
      // 
      // txtOutput
      // 
      this.txtOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(22)))), ((int)(((byte)(44)))));
      this.txtOutput.Dock = System.Windows.Forms.DockStyle.Fill;
      this.txtOutput.ForeColor = System.Drawing.Color.White;
      this.txtOutput.Location = new System.Drawing.Point(3, 26);
      this.txtOutput.Name = "txtOutput";
      this.txtOutput.Size = new System.Drawing.Size(776, 488);
      this.txtOutput.TabIndex = 0;
      this.txtOutput.Text = "";
      this.txtOutput.TextChanged += new System.EventHandler(this.txtOutput_TextChanged);
      // 
      // FormMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1113, 660);
      this.Controls.Add(this.tableLayoutPanel1);
      this.Controls.Add(this.barcode_reader);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Margin = new System.Windows.Forms.Padding(4);
      this.Name = "FormMain";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "VL Barcode Utility";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
      this.Load += new System.EventHandler(this.FormMain_Load);
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel2.ResumeLayout(false);
      this.tableLayoutPanel5.ResumeLayout(false);
      this.tableLayoutPanel5.PerformLayout();
      this.tableLayoutPanel3.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.picEnlarge)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.picNomal)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.picMin)).EndInit();
      this.tableLayoutPanel7.ResumeLayout(false);
      this.groupBox2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dgvMode)).EndInit();
      this.groupBox1.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private barcode.BarcodeUC barcode_reader;
    public System.Windows.Forms.Timer timerMqtt;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.PictureBox picExit;
    private System.Windows.Forms.Button btnSetting;
    private System.Windows.Forms.Button btnClear;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.DataGridView dgvMode;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.RichTextBox txtOutput;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
    private System.Windows.Forms.Label lblClock;
    private System.Windows.Forms.Button btnBarCode;
    private System.Windows.Forms.Button btnConnectNetwork;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.PictureBox picEnlarge;
    private System.Windows.Forms.PictureBox picNomal;
    private System.Windows.Forms.PictureBox picMin;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
  }
}

