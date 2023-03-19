namespace BarcodeScannerUsbUtility
{
  partial class FormLogin
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
      this.lblPasswd = new System.Windows.Forms.Label();
      this.txtPasswd = new System.Windows.Forms.TextBox();
      this.OK = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // lblPasswd
      // 
      this.lblPasswd.BackColor = System.Drawing.SystemColors.Control;
      this.lblPasswd.Location = new System.Drawing.Point(12, 11);
      this.lblPasswd.Name = "lblPasswd";
      this.lblPasswd.Size = new System.Drawing.Size(76, 20);
      this.lblPasswd.TabIndex = 0;
      this.lblPasswd.Text = "Pasword";
      this.lblPasswd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // txtPasswd
      // 
      this.txtPasswd.Location = new System.Drawing.Point(94, 12);
      this.txtPasswd.Name = "txtPasswd";
      this.txtPasswd.Size = new System.Drawing.Size(282, 20);
      this.txtPasswd.TabIndex = 1;
      this.txtPasswd.UseSystemPasswordChar = true;
      // 
      // OK
      // 
      this.OK.Location = new System.Drawing.Point(303, 38);
      this.OK.Name = "OK";
      this.OK.Size = new System.Drawing.Size(73, 25);
      this.OK.TabIndex = 2;
      this.OK.Text = "OK";
      this.OK.UseVisualStyleBackColor = true;
      this.OK.Click += new System.EventHandler(this.OK_Click);
      // 
      // FormLogin
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(410, 73);
      this.Controls.Add(this.OK);
      this.Controls.Add(this.txtPasswd);
      this.Controls.Add(this.lblPasswd);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.Name = "FormLogin";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "VL Barcode Utility - Login";
      this.Load += new System.EventHandler(this.FormLogin_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private System.Windows.Forms.Label lblPasswd;
        private System.Windows.Forms.TextBox txtPasswd;
        private System.Windows.Forms.Button OK;
    }
}