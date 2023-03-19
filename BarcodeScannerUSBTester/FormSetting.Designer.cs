namespace BarcodeScannerUsbUtility
{
  partial class FormSetting
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
      this.OK = new System.Windows.Forms.Button();
      this.txtPort = new System.Windows.Forms.TextBox();
      this.txtIP = new System.Windows.Forms.TextBox();
      this.txtPid = new System.Windows.Forms.TextBox();
      this.txtVid = new System.Windows.Forms.TextBox();
      this.lblPort = new System.Windows.Forms.Label();
      this.lblHostIp = new System.Windows.Forms.Label();
      this.lblPid = new System.Windows.Forms.Label();
      this.lblVid = new System.Windows.Forms.Label();
      this.groupBarcodeReader = new System.Windows.Forms.GroupBox();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.checkBoxAutoConnect = new System.Windows.Forms.CheckBox();
      this.groupBarcodeReader.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.SuspendLayout();
      // 
      // OK
      // 
      this.OK.Location = new System.Drawing.Point(512, 38);
      this.OK.Name = "OK";
      this.OK.Size = new System.Drawing.Size(90, 38);
      this.OK.TabIndex = 4;
      this.OK.Text = "OK";
      this.OK.UseVisualStyleBackColor = true;
      this.OK.Click += new System.EventHandler(this.OK_Click);
      // 
      // txtPort
      // 
      this.txtPort.Location = new System.Drawing.Point(63, 45);
      this.txtPort.Name = "txtPort";
      this.txtPort.Size = new System.Drawing.Size(73, 20);
      this.txtPort.TabIndex = 3;
      // 
      // txtIP
      // 
      this.txtIP.Location = new System.Drawing.Point(63, 19);
      this.txtIP.Name = "txtIP";
      this.txtIP.Size = new System.Drawing.Size(203, 20);
      this.txtIP.TabIndex = 2;
      // 
      // txtPid
      // 
      this.txtPid.Location = new System.Drawing.Point(68, 45);
      this.txtPid.Name = "txtPid";
      this.txtPid.Size = new System.Drawing.Size(101, 20);
      this.txtPid.TabIndex = 1;
      // 
      // txtVid
      // 
      this.txtVid.Location = new System.Drawing.Point(68, 19);
      this.txtVid.Name = "txtVid";
      this.txtVid.Size = new System.Drawing.Size(101, 20);
      this.txtVid.TabIndex = 0;
      // 
      // lblPort
      // 
      this.lblPort.BackColor = System.Drawing.SystemColors.Control;
      this.lblPort.Location = new System.Drawing.Point(10, 42);
      this.lblPort.Name = "lblPort";
      this.lblPort.Size = new System.Drawing.Size(47, 20);
      this.lblPort.TabIndex = 0;
      this.lblPort.Text = "PORT";
      this.lblPort.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // lblHostIp
      // 
      this.lblHostIp.BackColor = System.Drawing.SystemColors.Control;
      this.lblHostIp.Location = new System.Drawing.Point(10, 16);
      this.lblHostIp.Name = "lblHostIp";
      this.lblHostIp.Size = new System.Drawing.Size(47, 20);
      this.lblHostIp.TabIndex = 0;
      this.lblHostIp.Text = "IP";
      this.lblHostIp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // lblPid
      // 
      this.lblPid.BackColor = System.Drawing.SystemColors.Control;
      this.lblPid.Location = new System.Drawing.Point(6, 44);
      this.lblPid.Name = "lblPid";
      this.lblPid.Size = new System.Drawing.Size(38, 20);
      this.lblPid.TabIndex = 0;
      this.lblPid.Text = "PID";
      this.lblPid.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // lblVid
      // 
      this.lblVid.BackColor = System.Drawing.SystemColors.Control;
      this.lblVid.Location = new System.Drawing.Point(6, 19);
      this.lblVid.Name = "lblVid";
      this.lblVid.Size = new System.Drawing.Size(38, 18);
      this.lblVid.TabIndex = 0;
      this.lblVid.Text = "VID";
      this.lblVid.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // groupBarcodeReader
      // 
      this.groupBarcodeReader.Controls.Add(this.txtVid);
      this.groupBarcodeReader.Controls.Add(this.lblVid);
      this.groupBarcodeReader.Controls.Add(this.txtPid);
      this.groupBarcodeReader.Controls.Add(this.lblPid);
      this.groupBarcodeReader.Location = new System.Drawing.Point(12, 12);
      this.groupBarcodeReader.Name = "groupBarcodeReader";
      this.groupBarcodeReader.Size = new System.Drawing.Size(190, 83);
      this.groupBarcodeReader.TabIndex = 5;
      this.groupBarcodeReader.TabStop = false;
      this.groupBarcodeReader.Text = "Barcode Reader";
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.checkBoxAutoConnect);
      this.groupBox2.Controls.Add(this.txtPort);
      this.groupBox2.Controls.Add(this.lblHostIp);
      this.groupBox2.Controls.Add(this.txtIP);
      this.groupBox2.Controls.Add(this.lblPort);
      this.groupBox2.Location = new System.Drawing.Point(208, 12);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(298, 83);
      this.groupBox2.TabIndex = 6;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Network";
      // 
      // checkBoxAutoConnect
      // 
      this.checkBoxAutoConnect.AutoSize = true;
      this.checkBoxAutoConnect.Location = new System.Drawing.Point(175, 45);
      this.checkBoxAutoConnect.Name = "checkBoxAutoConnect";
      this.checkBoxAutoConnect.Size = new System.Drawing.Size(91, 17);
      this.checkBoxAutoConnect.TabIndex = 4;
      this.checkBoxAutoConnect.Text = "Auto Connect";
      this.checkBoxAutoConnect.UseVisualStyleBackColor = true;
      // 
      // FormSetting
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(616, 106);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.groupBarcodeReader);
      this.Controls.Add(this.OK);
      this.MinimizeBox = false;
      this.Name = "FormSetting";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "VL Barcode Utility - Settings";
      this.Load += new System.EventHandler(this.FormSystemConFig_Load);
      this.groupBarcodeReader.ResumeLayout(false);
      this.groupBarcodeReader.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.ResumeLayout(false);

    }

        #endregion
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.TextBox txtPid;
        private System.Windows.Forms.TextBox txtVid;
        private System.Windows.Forms.Label lblHostIp;
        private System.Windows.Forms.Label lblPid;
        private System.Windows.Forms.Label lblVid;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.Button OK;
    private System.Windows.Forms.GroupBox groupBarcodeReader;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.CheckBox checkBoxAutoConnect;
  }
}