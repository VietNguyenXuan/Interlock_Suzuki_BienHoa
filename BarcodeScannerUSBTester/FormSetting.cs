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
  public partial class FormSetting : Form
  {
    public FormSetting()
    {
      InitializeComponent();
    }

    // Transfer forms
    private Form currentFormChild;
    private void openFormChild(Form formChild)
    {
      if (currentFormChild != null)
      {
        currentFormChild.Close();
      }
      currentFormChild = formChild;
      formChild.TopLevel = false;
      //formChild.FormBorderStyle = FormBorderStyle.None;
      formChild.Dock = DockStyle.Fill;
      pnlBodySetting.Controls.Add(formChild);
      pnlBodySetting.Tag = formChild;
      formChild.BringToFront();
      formChild.Show();
    }

    private void FormGeneralConFig_Load(object sender, EventArgs e)
    {
      this.Icon = Resource1.AppIcon;
      openFormChild(new FormChangePass());
      btnChangePassword.BackColor = Color.FromArgb(0, 128, 128);
      btnSystemConfig.BackColor = Color.FromArgb(5, 25, 62);
    }

    private void btnChangePassword_Click(object sender, EventArgs e)
    {
      //FormChangePass cp = new FormChangePass();
      //this.Hide();
      //cp.ShowDialog();
      //this.Show();


      openFormChild(new FormChangePass());
      btnChangePassword.BackColor = Color.FromArgb(0, 128, 128);
      btnSystemConfig.BackColor = Color.FromArgb(5, 25, 62);
    }

    private void btnSystemConfig_Click(object sender, EventArgs e)
    {
      //FormSetting sys = new FormSetting();
      //this.Hide();
      //sys.ShowDialog();
      //this.Show();

      openFormChild(new FormConfig());
      btnChangePassword.BackColor = Color.FromArgb(5, 25, 62);
      btnSystemConfig.BackColor = Color.FromArgb(0, 128, 128);
    }

    private void pictureExit_Click(object sender, EventArgs e)
    {
      this.Close();
    }
  }
}
