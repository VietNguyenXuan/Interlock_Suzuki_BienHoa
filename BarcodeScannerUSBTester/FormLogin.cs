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

    private void FormLogin_Load(object sender, EventArgs e)
    {
      this.Icon = Resource1.AppIcon;
      this.StartPosition = FormStartPosition.CenterScreen;
    }

    private void btnLogIn_Click(object sender, EventArgs e)
    {
      if (this.txtPassword.Text == CONFIG.ReadSetting("pass").ToString())
      {
        FormSetting gen = new FormSetting();
        this.Hide();
        gen.ShowDialog();
        this.Close();
      }
      else
      {
        MessageBox.Show("Wrong password! Please try again");
      }
    }

    private void picExit_Click(object sender, EventArgs e)
    {
      this.Close();
    }
  }
}
