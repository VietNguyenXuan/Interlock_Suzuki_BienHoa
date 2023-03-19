namespace barcode
{
  partial class BarcodeUC
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

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.txtBarcodeScanner_Backup = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.txtBarcodeScanner_IFM = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // txtBarcodeScanner_Backup
      // 
      this.txtBarcodeScanner_Backup.Enabled = false;
      this.txtBarcodeScanner_Backup.Location = new System.Drawing.Point(3, 69);
      this.txtBarcodeScanner_Backup.Name = "txtBarcodeScanner_Backup";
      this.txtBarcodeScanner_Backup.Size = new System.Drawing.Size(258, 20);
      this.txtBarcodeScanner_Backup.TabIndex = 0;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
      this.label1.Location = new System.Drawing.Point(3, 49);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(192, 17);
      this.label1.TabIndex = 1;
      this.label1.Text = "Barcode scanner  - SAVE";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
      this.label2.Location = new System.Drawing.Point(3, 1);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(186, 17);
      this.label2.TabIndex = 3;
      this.label2.Text = "Barcode scanner 1 - IFM";
      // 
      // txtBarcodeScanner_IFM
      // 
      this.txtBarcodeScanner_IFM.Enabled = false;
      this.txtBarcodeScanner_IFM.Location = new System.Drawing.Point(3, 21);
      this.txtBarcodeScanner_IFM.Name = "txtBarcodeScanner_IFM";
      this.txtBarcodeScanner_IFM.Size = new System.Drawing.Size(258, 20);
      this.txtBarcodeScanner_IFM.TabIndex = 2;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
      this.label3.Location = new System.Drawing.Point(3, 96);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(129, 17);
      this.label3.TabIndex = 70;
      this.label3.Text = "Waiting from box";
      
      // 
      // BarcodeUC
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(244)))), ((int)(((byte)(247)))));
      this.Controls.Add(this.label3);
      this.Controls.Add(this.txtBarcodeScanner_IFM);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.txtBarcodeScanner_Backup);
      this.Name = "BarcodeUC";
      this.Size = new System.Drawing.Size(265, 117);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox txtBarcodeScanner_Backup;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtBarcodeScanner_IFM;
    private System.Windows.Forms.Label label3;
  }
}
