using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BarcodeScannerUsbUtility.Controls;
using BarcodeUtility;

namespace BarcodeScannerUsbUtility
{
  public partial class FormChangePass : Form
  {
    public FormChangePass()
    {
      InitializeComponent();
    }

    private void FormChangePass_Load(object sender, EventArgs e)
    {
      this.Icon = Resource1.AppIcon;
    }

    private void btnOk_Click_1(object sender, EventArgs e)
    {
      if (txtOldPass.Text != CONFIG.ReadSetting("pass").ToString())
      {
        MessageBox.Show("Wrong password! Please try again");
      }
      else if (this.txtNewPassword.Text != this.txtRetypePassword.Text)
      {
        MessageBox.Show("Retype password and new password do not match! Please try again");
      }
      else
      {
        CONFIG.UpdateAppSettings("pass", this.txtNewPassword.Text.ToString());
        MessageBox.Show("Change password success!");
      }
    }
  }
}
