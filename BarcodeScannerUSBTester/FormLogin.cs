using BarcodeScannerUsbUtility.Controls;
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
  public partial class FormLogin : Form
  {
    public FormLogin()
    {
      InitializeComponent();
    }

    private void OK_Click(object sender, EventArgs e)
    {
      if (this.txtPasswd.Text == CONFIG.ReadSetting("pass").ToString())
      {
        FormGeneralConFig gen = new FormGeneralConFig();
        this.Hide();
        gen.ShowDialog();
        this.Close();
      }
      else
      {
        MessageBox.Show("Wrong password! Please try again");
      }
    }

    private void FormLogin_Load(object sender, EventArgs e)
    {
      this.Icon = Resource1.AppIcon;
      this.StartPosition = FormStartPosition.CenterScreen;
    }
  }
}
