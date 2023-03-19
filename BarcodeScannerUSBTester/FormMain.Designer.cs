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
      this.panel1 = new System.Windows.Forms.Panel();
      this.btClearBarcodeData = new System.Windows.Forms.Button();
      this.lblStatus = new System.Windows.Forms.Label();
      this.lblNetworkConnection = new System.Windows.Forms.Label();
      this.panelNetworkStt = new System.Windows.Forms.Panel();
      this.btnHide = new System.Windows.Forms.Button();
      this.barcode_reader = new barcode.BarcodeUC();
      this.btnConnectNetwork = new System.Windows.Forms.Button();
      this.btnSetting = new System.Windows.Forms.Button();
      this.lblCoppyRight = new System.Windows.Forms.Label();
      this.txtOutput = new System.Windows.Forms.RichTextBox();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.timerMqtt = new System.Windows.Forms.Timer(this.components);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.Color.Red;
      this.panel1.Location = new System.Drawing.Point(191, 12);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(23, 13);
      this.panel1.TabIndex = 1;
      // 
      // btClearBarcodeData
      // 
      this.btClearBarcodeData.Location = new System.Drawing.Point(392, 12);
      this.btClearBarcodeData.Name = "btClearBarcodeData";
      this.btClearBarcodeData.Size = new System.Drawing.Size(71, 38);
      this.btClearBarcodeData.TabIndex = 2;
      this.btClearBarcodeData.Text = "Clear";
      this.btClearBarcodeData.UseVisualStyleBackColor = true;
      this.btClearBarcodeData.Click += new System.EventHandler(this.btClearBarcodeData_Click);
      // 
      // lblStatus
      // 
      this.lblStatus.AutoSize = true;
      this.lblStatus.Location = new System.Drawing.Point(93, 12);
      this.lblStatus.Name = "lblStatus";
      this.lblStatus.Size = new System.Drawing.Size(92, 13);
      this.lblStatus.TabIndex = 3;
      this.lblStatus.Text = "Barcode connect:";
      // 
      // lblNetworkConnection
      // 
      this.lblNetworkConnection.AutoSize = true;
      this.lblNetworkConnection.Location = new System.Drawing.Point(93, 37);
      this.lblNetworkConnection.Name = "lblNetworkConnection";
      this.lblNetworkConnection.Size = new System.Drawing.Size(92, 13);
      this.lblNetworkConnection.TabIndex = 5;
      this.lblNetworkConnection.Text = "Network connect:";
      // 
      // panelNetworkStt
      // 
      this.panelNetworkStt.BackColor = System.Drawing.Color.Red;
      this.panelNetworkStt.Location = new System.Drawing.Point(191, 37);
      this.panelNetworkStt.Name = "panelNetworkStt";
      this.panelNetworkStt.Size = new System.Drawing.Size(23, 13);
      this.panelNetworkStt.TabIndex = 4;
      // 
      // btnHide
      // 
      this.btnHide.Location = new System.Drawing.Point(469, 12);
      this.btnHide.Name = "btnHide";
      this.btnHide.Size = new System.Drawing.Size(71, 38);
      this.btnHide.TabIndex = 7;
      this.btnHide.Text = "Hide";
      this.btnHide.UseVisualStyleBackColor = true;
      this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
      // 
      // barcode_reader
      // 
      this.barcode_reader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(244)))), ((int)(((byte)(247)))));
      this.barcode_reader.Location = new System.Drawing.Point(15, 249);
      this.barcode_reader.Name = "barcode_reader";
      this.barcode_reader.Size = new System.Drawing.Size(76, 25);
      this.barcode_reader.TabIndex = 0;
      this.barcode_reader.Visible = false;
      // 
      // btnConnectNetwork
      // 
      this.btnConnectNetwork.Location = new System.Drawing.Point(315, 12);
      this.btnConnectNetwork.Name = "btnConnectNetwork";
      this.btnConnectNetwork.Size = new System.Drawing.Size(71, 38);
      this.btnConnectNetwork.TabIndex = 10;
      this.btnConnectNetwork.Text = "Reconnect network";
      this.btnConnectNetwork.UseVisualStyleBackColor = true;
      this.btnConnectNetwork.Click += new System.EventHandler(this.btnConnectNetork_Click);
      // 
      // btnSetting
      // 
      this.btnSetting.AutoSize = true;
      this.btnSetting.Location = new System.Drawing.Point(239, 12);
      this.btnSetting.Name = "btnSetting";
      this.btnSetting.Size = new System.Drawing.Size(70, 38);
      this.btnSetting.TabIndex = 11;
      this.btnSetting.Text = "Setting";
      this.btnSetting.UseVisualStyleBackColor = true;
      this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
      // 
      // lblCoppyRight
      // 
      this.lblCoppyRight.AutoSize = true;
      this.lblCoppyRight.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
      this.lblCoppyRight.Location = new System.Drawing.Point(9, 315);
      this.lblCoppyRight.Name = "lblCoppyRight";
      this.lblCoppyRight.Size = new System.Drawing.Size(231, 13);
      this.lblCoppyRight.TabIndex = 12;
      this.lblCoppyRight.Text = "Coppyright © 2020 VuleTech. All rights resered.";
      // 
      // txtOutput
      // 
      this.txtOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.txtOutput.Enabled = false;
      this.txtOutput.Location = new System.Drawing.Point(12, 60);
      this.txtOutput.Name = "txtOutput";
      this.txtOutput.Size = new System.Drawing.Size(528, 248);
      this.txtOutput.TabIndex = 13;
      this.txtOutput.Text = "";
      this.txtOutput.TextChanged += new System.EventHandler(this.txtOutput_TextChanged);
      // 
      // pictureBox1
      // 
      this.pictureBox1.Image = global::BarcodeUtility.Properties.Resources.logoVule;
      this.pictureBox1.Location = new System.Drawing.Point(12, 12);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(59, 42);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pictureBox1.TabIndex = 14;
      this.pictureBox1.TabStop = false;
      // 
      // timerMqtt
      // 
      this.timerMqtt.Tick += new System.EventHandler(this.timerMqtt_Tick);
      // 
      // FormMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(552, 333);
      this.Controls.Add(this.pictureBox1);
      this.Controls.Add(this.txtOutput);
      this.Controls.Add(this.lblCoppyRight);
      this.Controls.Add(this.btnSetting);
      this.Controls.Add(this.btnConnectNetwork);
      this.Controls.Add(this.btnHide);
      this.Controls.Add(this.lblNetworkConnection);
      this.Controls.Add(this.panelNetworkStt);
      this.Controls.Add(this.lblStatus);
      this.Controls.Add(this.btClearBarcodeData);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.barcode_reader);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.Name = "FormMain";
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "VL Barcode Utility";
      this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
      this.Load += new System.EventHandler(this.FormMain_Load);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private barcode.BarcodeUC barcode_reader;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Button btClearBarcodeData;
    private System.Windows.Forms.Label lblStatus;
    private System.Windows.Forms.Label lblNetworkConnection;
    private System.Windows.Forms.Panel panelNetworkStt;
    private System.Windows.Forms.Button btnHide;
    private System.Windows.Forms.Button btnConnectNetwork;
    private System.Windows.Forms.Button btnSetting;
    private System.Windows.Forms.Label lblCoppyRight;
    private System.Windows.Forms.RichTextBox txtOutput;
    private System.Windows.Forms.PictureBox pictureBox1;
    public System.Windows.Forms.Timer timerMqtt;
  }
}

