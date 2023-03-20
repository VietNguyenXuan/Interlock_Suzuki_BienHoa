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
  public partial class FormConfig : Form
  {
    public FormConfig()
    {
      InitializeComponent();
    }

    private void FormSystemConFig_Load(object sender, EventArgs e)
    {
      this.txtVID.Text=CONFIG.ReadSetting("VID");
      this.txtPID.Text = CONFIG.ReadSetting("PID");
      this.txtIP.Text = CONFIG.ReadSetting("IP");
      this.txtPort.Text = CONFIG.ReadSetting("PORT");
      this.Icon = Resource1.AppIcon;
      this.StartPosition = FormStartPosition.CenterScreen;
      chkAutoConnect.DataBindings.Add("Checked", Settings.Default, "isAutoConnect");
    }

    private bool isDiffConfigValue()
    {
      Config.Load();
      if ((Config.Barcode.vid != txtVID.Text) || (Config.Barcode.pid != txtPID.Text) || (Config.Network.ip != txtIP.Text) || (Config.Network.port != txtPort.Text)) return true;
      return false;
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
      if (isDiffConfigValue())
      {
        if (MessageBox.Show("Do you want to change the value?", "CONFIRM", MessageBoxButtons.OKCancel) == DialogResult.OK)
        {
          CONFIG.UpdateAppSettings("VID", this.txtVID.Text);
          CONFIG.UpdateAppSettings("PID", this.txtPID.Text);
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
    }
  }
}
