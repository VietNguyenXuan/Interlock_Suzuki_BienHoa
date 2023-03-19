using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BarcodeScannerUsbUtility
{
  public partial class FormGeneralConFig : Form
  {
    public FormGeneralConFig()
    {
      InitializeComponent();
    }

    private void SYSTEM_Click(object sender, EventArgs e)
    {
      FormSetting sys = new FormSetting();
      this.Hide();
      sys.ShowDialog();
      this.Show();
    }

    private void PASSWORD_Click(object sender, EventArgs e)
    {
      FormChangePass cp = new FormChangePass();
      this.Hide();
      cp.ShowDialog();
      this.Show();
    }

    private void FormGeneralConFig_Load(object sender, EventArgs e)
    {
      this.Icon = Resource1.AppIcon;
      this.StartPosition = FormStartPosition.CenterScreen;
    }
  }
}
