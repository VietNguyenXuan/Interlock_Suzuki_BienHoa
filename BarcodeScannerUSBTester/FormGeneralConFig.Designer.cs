namespace BarcodeScannerUsbUtility
{
  partial class FormGeneralConFig
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
      this.PASSWORD = new System.Windows.Forms.Button();
      this.SYSTEM = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // PASSWORD
      // 
      this.PASSWORD.Location = new System.Drawing.Point(12, 12);
      this.PASSWORD.Name = "PASSWORD";
      this.PASSWORD.Size = new System.Drawing.Size(158, 28);
      this.PASSWORD.TabIndex = 0;
      this.PASSWORD.Text = "CHANGE PASSWORD";
      this.PASSWORD.UseVisualStyleBackColor = true;
      this.PASSWORD.Click += new System.EventHandler(this.PASSWORD_Click);
      // 
      // SYSTEM
      // 
      this.SYSTEM.Location = new System.Drawing.Point(199, 12);
      this.SYSTEM.Name = "SYSTEM";
      this.SYSTEM.Size = new System.Drawing.Size(158, 28);
      this.SYSTEM.TabIndex = 1;
      this.SYSTEM.Text = "SYSTEM CONFIG";
      this.SYSTEM.UseVisualStyleBackColor = true;
      this.SYSTEM.Click += new System.EventHandler(this.SYSTEM_Click);
      // 
      // FormGeneralConFig
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(373, 52);
      this.Controls.Add(this.SYSTEM);
      this.Controls.Add(this.PASSWORD);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.Name = "FormGeneralConFig";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "VL Barcode Utility - Settings";
      this.Load += new System.EventHandler(this.FormGeneralConFig_Load);
      this.ResumeLayout(false);

    }

        #endregion

        private System.Windows.Forms.Button PASSWORD;
        private System.Windows.Forms.Button SYSTEM;
    }
}