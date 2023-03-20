using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using barcode;
using LibUsbDotNet.DeviceNotify;
using LibUsbDotNet.Usb;
using LibUsbDotNet.Usb.Main;
using BarcodeScannerUsbUtility.Controls;
using MqttLib;
using Newtonsoft.Json;
using System.Configuration;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using BarcodeUtility.Properties;

namespace BarcodeScannerUsbUtility
{
  public partial class FormMain : Form
  {
    public delegate void MethodInvoker();
    public FormLogin login = new FormLogin();
    private DeviceNotifier mDevNotifier;
    #region Nested type: DeviceNotifyEventDelegate
    private delegate void DeviceNotifyEventDelegate(object sender, DeviceNotifyEventArgs e);
    #endregion

    private LibUsbDotNet.DeviceNotify.Info.UsbDeviceNotifyInfo usb_device = null;
    private EventType usb_event_type = EventType.CUSTOMEVENT;

    private Timer barcode_timer_Notify = new Timer();
    private Timer mqtt_timer_connect = new Timer();

    private string my_barcode_VID = "0x0C2E";
    private string my_barcode_PID = "0x0901";

    private static string connStringMqtt;// = $"TCP://{getIp()}:1883";

    public static IMqtt _Client;// = MqttClientFactory.CreateClient();
    public static Logger logger = new Logger();

    #region Singleton Form

    private static FormMain _Instance = new FormMain();
    private FormMain _FormMain;
    public static FormMain Instance()
    {
      if (_Instance == null)
      {
        _Instance = new FormMain();
      }
      return _Instance;
    }

    #endregion


    //private FormMain(string[] args)
    private FormMain()
    {
      InitializeComponent();

      Settings.Default.Reload();
      //check if config file not found.
      var appSettings = ConfigurationManager.AppSettings;
      //load config value
      if (appSettings.Count > 0)
      {
        try
        {
          Config.Barcode.vid = appSettings["VID"];
          Config.Barcode.pid = appSettings["PID"];
          Config.Network.ip = appSettings["IP"];
          Config.Network.port = appSettings["PORT"];
          Config.pass = appSettings["pass"];
        }
        catch (ConfigurationException ex)
        {
          logger.WriteErrorLog(ex, false);
        }
      }

      //set config value
      connStringMqtt = Config.Network.GetConnectionString();
      my_barcode_VID = Config.Barcode.vid;
      my_barcode_PID = Config.Barcode.pid;

      /*
      int a = args.Count();
      if (args.Count() > 0)
      {
        my_barcode_VID = args[0];
        my_barcode_PID = args[1];
        connStringMqtt = args[2];
      }
      */
      Mqtt_Connect_To_Broker();
      //try
      //{
      //  _Client = MqttClientFactory.CreateClient(connStringMqtt, "InterlockBienHoa");
      //  _Client.Connected += _Client_Connected;
      //  _Client.ConnectionLost += _Client_ConnectionLost;
      //  _Client.Connect(true);
      //}
      //catch (Exception ex)
      //{
      //  new Logger().WriteErrorLog(ex);
      //}

      //
      //
      barcode_timer_Notify.Interval = 1000;
      barcode_timer_Notify.Tick += new EventHandler(timer_barcode_Notify_Tick);

      mqtt_timer_connect.Interval = 1000;
      mqtt_timer_connect.Tick += new EventHandler(mqtt_timer_check_connect_Tick);

      mDevNotifier = new DeviceNotifier();
      mDevNotifier.OnDeviceNotify += new EventHandler<DeviceNotifyEventArgs>(mDevNotifier_OnDeviceNotify);
      //
      barcode_reader.OnFlushData += new barcode.BarcodeUC.FlushData(barcode_reader_OnFlushData); //new BarcodeUC.FlushData(barcode_reader_OnFlushData);
      barcode_reader.OnBarcodeUSBConnect += new BarcodeUC.BarcodeUSBConnect(barcode_reader_OnBarcodeUSBConnect);


      /* ************* setup barcode scanner **************/
      List<barcode.BarcodeUC.BarcodeScannerType> list_barcode_scanner = ConvertListBarcodeScanner();
      barcode_reader.SetupBarcode(list_barcode_scanner);

      this.barcode_reader.MakeFocusToBarcodeScanner(false);

      //this.Visible = false;
      //this.Hide();
      //this.ShowInTaskbar = false;


    }



    private void mDevNotifier_OnDeviceNotify(object sender, DeviceNotifyEventArgs e)
    {
      Invoke(new DeviceNotifyEventDelegate(OnDevNotify), new object[] { sender, e });
    }

    private List<BarcodeUC.BarcodeScannerType> ConvertListBarcodeScanner()
    {
      List<BarcodeUC.BarcodeScannerType> list_barcode_scanner = new List<BarcodeUC.BarcodeScannerType>();
      BarcodeUC.BarcodeScannerType barcode = new BarcodeUC.BarcodeScannerType();
      barcode.id = "1";
      barcode.VID = my_barcode_VID;// "0x0C2E";
      barcode.PID = my_barcode_PID;// "0x0901";
      //add to list
      list_barcode_scanner.Add(barcode);

      return list_barcode_scanner;
    }


    private void barcode_reader_OnFlushData(object sender, string data)
    {
      //if ()
      try
      {
        string dataJson = JsonConvert.SerializeObject(new Logger() { Title = "Barcoder", Message = data, Time = DateTime.Now.ToString() });
        if (_Client.IsConnected)
        {
          _Client.Publish(new MqttParcel(Settings.Default.mqtt_topic_data, dataJson, QoS.OnceAndOnceOnly, false));
          logger.WriteToLogFile(data);
        }
        else txtOutput.AppendText("Network lost connect. Can't not send data. \n");

        //if(data.Length == 17)
        //txtShowData.AppendText("\n");
        //txtShowData.AppendText($"Barcode Data: {data}");
        //txtShowData.AppendText($"Time: {DateTime.Now.ToString()}");
        //txtShowData.AppendText("\n");
        
        txtOutput.AppendText("\n");
        txtOutput.AppendText($"Barcode Data: {data}\n");
        txtOutput.AppendText($"Time: {DateTime.Now.ToString()}");
        txtOutput.AppendText("\n");
        txtOutput.Select(txtOutput.TextLength-1, 1);
      }
      catch (Exception ex)
      {
        logger.WriteErrorLog(ex);
        txtOutput.AppendText(ex.Message);
      }
    }

    private void OnDevNotify(object sender, DeviceNotifyEventArgs e)
    {
      object[] o = new object[] { e.EventType.ToString(), DateTime.Now.ToString(), e.DeviceType.ToString(), e.Object.ToString() };
      string s = String.Format("{0} - Time: {1}  -  {2}\r\n{3}", o);
      if (e.DeviceType == DeviceType.DEVICEINTERFACE && e.EventType == EventType.DEVICEARRIVAL)
        s += "\r\n" + e.Device.SymbolicName.FullName;
      usb_device = e.Device;
      usb_event_type = e.EventType;
      barcode_timer_Notify.Enabled = true;
    }
    static private bool pIsFoundCorrectBarcode = true;
    private void timer_barcode_Notify_Tick(object sender, EventArgs e)
    {
      barcode_timer_Notify.Enabled = false;
      try
      {
        string device_infor_VID = String.Format("0x{0}", usb_device.IdVendor.ToString("X").PadLeft(4, '0')).ToLower();
        string device_infor_PID = String.Format("0x{0}", usb_device.IdProduct.ToString("X").PadLeft(4, '0')).ToLower();
        bool IsFoundCorrectBarcode = false;

        if ((device_infor_VID == my_barcode_VID.ToLower()) && (device_infor_PID == my_barcode_PID.ToLower()))
        {
          if (usb_event_type == EventType.DEVICEREMOVECOMPLETE)
          {
            IsFoundCorrectBarcode = false;
          }
          else if (usb_event_type == EventType.DEVICEARRIVAL)
          {
            IsFoundCorrectBarcode = true;
          }
        }

        /* copy */

        this.barcode_reader.UpdateListBarcode(ConvertListBarcodeScanner());
        if (IsFoundCorrectBarcode == false)
        {
          this.barcode_reader.SetConnect(false);
          this.panel1.BackColor = Color.Red;

        }
        else
        {
          this.barcode_reader.SetConnect(true);
          this.panel1.BackColor = Color.Green;
        }
        if (IsFoundCorrectBarcode != pIsFoundCorrectBarcode)
        {
          PushlishMsg(IsFoundCorrectBarcode ? "connected" : "disconnected", Settings.Default.mqtt_topic_status, "Barcoder"); //#mqtt_msg
          logger.WriteToLogFile("Barcoder " + (IsFoundCorrectBarcode ? "connected" : "disconnected"));
          if (!IsFoundCorrectBarcode)
          {
            Settings.Default.barcoder_lasr_connect = DateTime.Now.ToString();
          }
          else
          {

          }
          pIsFoundCorrectBarcode = IsFoundCorrectBarcode;
        }
      }
      catch (Exception ex)
      {
        logger.WriteErrorLog(ex,false);
      }
    }


    private void barcode_reader_OnBarcodeUSBConnect(object sender, bool IsConnect, List<barcode.BarcodeUC.BarcodeScannerType> list_barcode_scanner)
    {
      if (IsConnect == false)
      {
        this.panel1.BackColor = Color.Red;//.SetConnect_Barcode(DataTypes.COMM_STATUS.DISCONNECT);
      }
      else
      {
        this.panel1.BackColor = Color.Green;//communicationStatusByLed1.SetConnect_Barcode(DataTypes.COMM_STATUS.CONNECT);
      }

    }


    private void FormMain_Load(object sender, EventArgs e)
    {
      txtOutput.Multiline = true;
      mqtt_timer_connect.Enabled = true;
      this.Icon = Resources.AppIcon;
      txtOutput.AutoWordSelection = true;
      Task.Factory.StartNew(() => { MessageBox.Show("Barcode Utility started!", "VL Barcode Utility", MessageBoxButtons.OK, MessageBoxIcon.Information); });
      timerMqtt.Interval = 5000;
      timerMqtt.Enabled = Settings.Default.isAutoConnect;
    }
    private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
    {
      //if (IsInstanceApp)
      //{
      Settings.Default.CheckRunning = false;
      if (_Client.IsConnected) PushlishMsg("losed", Settings.Default.mqtt_topic_status, "BarcodeUtility"); Task.WaitAll(); _Client.Disconnect();
      Settings.Default.mqtt_last_connect = DateTime.Now.ToString();
      Settings.Default.Save();
      //}
    }

    #region Menthod
    public void EnableBtnReconnect()
    {
      btnReconnect.Enabled = true;
      btnReconnect.ForeColor = Color.White;
    }
    #endregion

    #region MQTT
    private void mqtt_timer_check_connect_Tick(object sender, EventArgs e)
    {
      if (_Client.IsConnected)
      {
        panelNetworkStt.BackColor = Color.Green;
      }
      else
      {
        panelNetworkStt.BackColor = Color.Red;
        btnReconnect.Enabled = true;
        btnReconnect.ForeColor = Color.White;
      }

    }
    static DateTime lastConnectNetwork;
    private bool IsInstanceApp = false;

    private void PushlishMsg(string data, string topic, string title)
    {
      //try
      //{
      string dataJson = JsonConvert.SerializeObject(new Logger() { Title = $"{title}", Message = data, Time = DateTime.Now.ToString() });
      if (_Client.IsConnected) _Client.Publish(new MqttParcel(topic, dataJson, QoS.OnceAndOnceOnly, false));//#mqtt_msg
      else
      {
        txtOutput.AppendText("Network disconnected. Can't send data.\n");
        logger.WriteErrorLog("Network disconnected. Can't send data.\n", false);
      }
      //}
      //catch (Exception ex)
      //{
      //  logger.WriteErrorLog(ex, false);
      //  txtShowData.AppendText(ex.Message);
      //}
    }
    private void _Client_ConnectionLost(object sender, EventArgs e)
    {
      panelNetworkStt.BackColor = Color.Red;
      btnReconnect.Enabled = true;
      btnReconnect.ForeColor = Color.White;
      logger.WriteErrorLog("Error: Network disconnected");
      lastConnectNetwork = DateTime.Now;
      Settings.Default.mqtt_last_connect = DateTime.Now.ToString();
      Settings.Default.Save();
      txtOutput.AppendText("Network disconnected\n");
    }

    private void _Client_Connected(object sender, EventArgs e)
    {
      PushlishMsg("connected", Settings.Default.mqtt_topic_status, "Publisher");
      PushlishMsg("last_disconnected:" + Settings.Default.mqtt_last_connect, Settings.Default.mqtt_topic_status, "Publisher"); //#mqtt_msg
      panelNetworkStt.BackColor = Color.Green;
      btnReconnect.Enabled = false;
      btnReconnect.ForeColor = Color.White;
      txtOutput.AppendText("Network connect success! \n");

      logger.WriteToLogFile("Network connect success");
    }
   
    private void Mqtt_Connect_To_Broker()
    {
      try
      {
        Int32 unixTimestamp = (Int32)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
        _Client = MqttClientFactory.CreateClient(Config.Network.GetConnectionString(), $"BarcodeUtility{unixTimestamp}");
        _Client.Connected += _Client_Connected;
        _Client.ConnectionLost += _Client_ConnectionLost;
        _Client.Connect(true);
      }
      catch (Exception ex)
      {
        logger.WriteErrorLog(ex);
      }
    }

    public void mqtt_Reconnect_to_Broker()
    {
      try
      {
        Int32 unixTimestamp = (Int32)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
        _Client = MqttClientFactory.CreateClient(Config.Network.GetConnectionString(), $"BarcodeUtility{unixTimestamp}");
        _Client.Connected += _Client_Connected;
        _Client.ConnectionLost += _Client_ConnectionLost;
        _Client.Connect(true);
      }
      catch (Exception ex)
      {
        logger.WriteErrorLog(ex,false);
      }
    }

    #endregion


    private void timerMqtt_Tick(object sender, EventArgs e)
    {
      if (_Client.IsConnected == false && Settings.Default.isAutoConnect)
      {
        btnReconnect_Click(sender, e);
      }
    }

    private void btnSetting_Click_1(object sender, EventArgs e)
    {
      //btnSetting.Enabled = false;
      login = new FormLogin();
      login.ShowDialog();
      //Task.Factory.StartNew(() =>
      //{
      //  try
      //  {
      //    login = new FormLogin();
      //    login.ShowDialog();

      //      //this.Invoke((MethodInvoker)delegate
      //      //{
      //      //  this.btnSetting.Enabled = true;
      //      //});
      //    }
      //  catch
      //  { }
      //});
    }

    private void btnReconnect_Click(object sender, EventArgs e)
    {
      //  if (connStringMqtt != Config.Network.GetConnectionString())
      //{
      //if (!_Client.IsConnected)
      //{
      //  //_Client.Disconnect();
      //  mqtt_Reconnect_to_Broker();
      //}
      //else 
      btnReconnect.Enabled = false;
      Task.Factory.StartNew(() =>
      {
        if (_Client.IsConnected)
        {
          _Client.Disconnect();
        }
        mqtt_Reconnect_to_Broker();
        Task.WaitAll();
        if (!_Client.IsConnected)
          this.Invoke((MethodInvoker)delegate
          {
            btnReconnect.Enabled = true;
          });
      });


      //if (_Client.IsConnected)
      //{
      //  _Client.Disconnect();
      //}
      //mqtt_Reconnect_to_Broker();
      //btnConnectNetwork.Enabled = false;
    }

    private void btnClear_Click(object sender, EventArgs e)
    {
      this.barcode_reader.SetBarcodeTextData("");
      txtOutput.Text = "";
    }

    private void btnHide_Click_1(object sender, EventArgs e)
    {
      //this.Hide();
      //this.Visible = false;
      this.WindowState = FormWindowState.Minimized;
    }

    private void txtOutput_TextChanged_1(object sender, EventArgs e)
    {
      // set the current caret position to the end
      txtOutput.SelectionStart = txtOutput.Text.Length;
      // scroll it automatically
      txtOutput.ScrollToCaret();
    }
  }
  public static class Config
  {
    public static class Barcode
    {
      public static string vid = "none";
      public static string pid = "none";
    }
    public static class Network
    {
      public static string ip = "localhost";
      public static string port = "1883";
      public static string GetConnectionString()
      {
        Config.Network.ip = ConfigurationManager.AppSettings["IP"];
        Config.Network.port = ConfigurationManager.AppSettings["PORT"];
        return $"TCP://{ip}:{port}";
      }
    }
    public static string pass = "123";

    public static void Load()
    {
      var appSettings = ConfigurationManager.AppSettings;
      //load config value
      if (appSettings.Count > 0)
      {
        Config.Barcode.vid = appSettings["VID"];
        Config.Barcode.pid = appSettings["PID"];
        Config.Network.ip = appSettings["IP"];
        Config.Network.port = appSettings["PORT"];
        Config.pass = appSettings["pass"];
      }
    }


  }
}
