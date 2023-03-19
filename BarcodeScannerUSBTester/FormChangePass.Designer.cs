namespace BarcodeScannerUsbUtility
{
  partial class FormChangePass
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
      this.lblNewPass = new System.Windows.Forms.Label();
      this.txtNewPass = new System.Windows.Forms.TextBox();
      this.lblRetypePass = new System.Windows.Forms.Label();
      this.txtRetype = new System.Windows.Forms.TextBox();
      this.btnOK = new System.Windows.Forms.Button();
      this.lblCurrentPass = new System.Windows.Forms.Label();
      this.txtOldPass = new System.Windows.Forms.TextBox();
      this.btnCancel = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // lblNewPass
      // 
      this.lblNewPass.BackColor = System.Drawing.SystemColors.Control;
      this.lblNewPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblNewPass.Location = new System.Drawing.Point(12, 35);
      this.lblNewPass.Name = "lblNewPass";
      this.lblNewPass.Size = new System.Drawing.Size(136, 19);
      this.lblNewPass.TabIndex = 0;
      this.lblNewPass.Text = "New Password";
      this.lblNewPass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // txtNewPass
      // 
      this.txtNewPass.Location = new System.Drawing.Point(176, 38);
      this.txtNewPass.Name = "txtNewPass";
      this.txtNewPass.Size = new System.Drawing.Size(250, 20);
      this.txtNewPass.TabIndex = 1;
      this.txtNewPass.UseSystemPasswordChar = true;
      // 
      // lblRetypePass
      // 
      this.lblRetypePass.BackColor = System.Drawing.SystemColors.Control;
      this.lblRetypePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblRetypePass.Location = new System.Drawing.Point(12, 61);
      this.lblRetypePass.Name = "lblRetypePass";
      this.lblRetypePass.Size = new System.Drawing.Size(136, 19);
      this.lblRetypePass.TabIndex = 0;
      this.lblRetypePass.Text = "Retype Password";
      this.lblRetypePass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // txtRetype
      // 
      this.txtRetype.Location = new System.Drawing.Point(176, 62);
      this.txtRetype.Name = "txtRetype";
      this.txtRetype.Size = new System.Drawing.Size(250, 20);
      this.txtRetype.TabIndex = 2;
      this.txtRetype.UseSystemPasswordChar = true;
      // 
      // btnOK
      // 
      this.btnOK.Location = new System.Drawing.Point(324, 88);
      this.btnOK.Name = "btnOK";
      this.btnOK.Size = new System.Drawing.Size(102, 28);
      this.btnOK.TabIndex = 3;
      this.btnOK.Text = "OK";
      this.btnOK.UseVisualStyleBackColor = true;
      this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
      // 
      // lblCurrentPass
      // 
      this.lblCurrentPass.BackColor = System.Drawing.SystemColors.Control;
      this.lblCurrentPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblCurrentPass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.lblCurrentPass.Location = new System.Drawing.Point(12, 9);
      this.lblCurrentPass.Name = "lblCurrentPass";
      this.lblCurrentPass.Size = new System.Drawing.Size(136, 19);
      this.lblCurrentPass.TabIndex = 0;
      this.lblCurrentPass.Text = "Current Password";
      this.lblCurrentPass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // txtOldPass
      // 
      this.txtOldPass.Location = new System.Drawing.Point(176, 12);
      this.txtOldPass.Name = "txtOldPass";
      this.txtOldPass.Size = new System.Drawing.Size(250, 20);
      this.txtOldPass.TabIndex = 0;
      this.txtOldPass.UseSystemPasswordChar = true;
      // 
      // btnCancel
      // 
      this.btnCancel.Location = new System.Drawing.Point(216, 88);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(102, 28);
      this.btnCancel.TabIndex = 4;
      this.btnCancel.Text = "Cancel";
      this.btnCancel.UseVisualStyleBackColor = true;
      this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
      // 
      // FormChangePass
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(440, 130);
      this.Controls.Add(this.btnCancel);
      this.Controls.Add(this.btnOK);
      this.Controls.Add(this.txtRetype);
      this.Controls.Add(this.txtOldPass);
      this.Controls.Add(this.txtNewPass);
      this.Controls.Add(this.lblRetypePass);
      this.Controls.Add(this.lblCurrentPass);
      this.Controls.Add(this.lblNewPass);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "FormChangePass";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "VL Barcode Utility - Change Password";
      this.Load += new System.EventHandler(this.FormChangePass_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private System.Windows.Forms.Label lblNewPass;
        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.Label lblRetypePass;
        private System.Windows.Forms.TextBox txtRetype;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblCurrentPass;
        private System.Windows.Forms.TextBox txtOldPass;
    private System.Windows.Forms.Button btnCancel;
  }
}