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
using BarcodeUtility.Properties;
//using MqttLib;

namespace BarcodeScannerUsbUtility
{
  public partial class FormSetting : Form
  {
    public FormSetting()
    {
      InitializeComponent();
    }

    private void OK_Click(object sender, EventArgs e)
    {
      if (isDiffConfigValue())
      {
        if (MessageBox.Show("Do you want to change the value?", "CONFIRM", MessageBoxButtons.OKCancel) == DialogResult.OK)
        {
          CONFIG.UpdateAppSettings("VID", this.txtVid.Text);
          CONFIG.UpdateAppSettings("PID", this.txtPid.Text);
          CONFIG.UpdateAppSettings("IP", this.txtIP.Text);
          CONFIG.UpdateAppSettings("PORT", this.txtPort.Text);
          Config.Load();
          Settings.Default.Save();
          Settings.Default.Reload();
          //FormMain.Instance().timerMqtt.Enabled = Settings.Default.isAutoConnect;
          //FormMain.ReConnectNetwork();
          FormMain.Instance().EnableBtnReconnect();
        }
        
      }
      else
      {
        MessageBox.Show("Nothing change");
      }
      this.Close();
    }

    private void FormSystemConFig_Load(object sender, EventArgs e)
    {
      this.txtVid.Text=CONFIG.ReadSetting("VID");
      this.txtPid.Text = CONFIG.ReadSetting("PID");
      this.txtIP.Text = CONFIG.ReadSetting("IP");
      this.txtPort.Text = CONFIG.ReadSetting("PORT");
      this.Icon = Resource1.AppIcon;
      this.StartPosition = FormStartPosition.CenterScreen;

      checkBoxAutoConnect.DataBindings.Add("Checked", Settings.Default, "isAutoConnect");
     
    }

    private void EXIT_Click(object sender, EventArgs e)
    {

    }

    private bool isDiffConfigValue()
    {
      Config.Load();
      if ((Config.Barcode.vid != txtVid.Text) || (Config.Barcode.pid != txtPid.Text) || (Config.Network.ip != txtIP.Text) || (Config.Network.port != txtPort.Text)) return true;
      return false;
    }
  }
}
