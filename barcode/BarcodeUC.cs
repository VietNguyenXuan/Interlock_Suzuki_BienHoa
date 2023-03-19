#define USING_USB_BARCODE
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using LibUsbDotNet.Usb;
using LibUsbDotNet.Usb.Main;
using LibUsbDotNet.DeviceNotify;
using System.Diagnostics;
using gma.System.Windows;
using System.IO.Ports;
//using BarcodeIFM_Tester;

namespace barcode
{
  public partial class BarcodeUC : UserControl
  {
    public delegate void FlushData(object sender, string data);
    public event FlushData OnFlushData;

    public delegate void FlushDataByText(object sender, string data);
    public event FlushDataByText OnFlushDataByText;

    public delegate void FlushDataByText_Barcode_IFM(object sender, int barcode_id, string barcode_data, int nReadCount, string GUID, string counter_id, DateTime datetime);
    public event FlushDataByText_Barcode_IFM OnFlushDataByText_Barcode_IFM;

    public delegate void BarcodeUSBConnect(object sender, bool IsConnect, List<BarcodeScannerType> list_barcode_scanner);
    public event BarcodeUSBConnect OnBarcodeUSBConnect;

    public delegate void BarcodeIFMConnect(object sender, bool IsConnect);
    public event BarcodeIFMConnect OnBarcodeIFMConnect;

    private UserActivityHook actHook;
    private List<Keys> KeysHook = new List<Keys>();
    private List<Keys> KeysHookReader = new List<Keys>();

    private Timer timer1;

    private bool IsConnect = false;

    private ushort VID = 0x0C2E;
    private ushort PID = 0x0204;

    private UsbDeviceList mDevList;
    private bool IsInProgress = false;

    private List<BarcodeScannerType> _list_barcode_scanner = new List<BarcodeScannerType>();
    //private UsbDevice mDev;
    //private UsbEndpointWriter mEpWriter;
    //private UsbEndpointReader mEpReader;
    private string barcode_data_full = "";
    /// <summary>
    /// MAX_BARCODE_LENGTH_ENABLE: 6
    /// </summary>
    private const int MAX_BARCODE_LENGTH_ENABLE = 6;
    private List<string> list_str = new List<string>();

    private string _barcodeIFM_COM = "";
    private int _barcodeIFM_id = 0;
    private int nReadCount = 0;



    //private BarcodeIFMdata BarcodeIFMdata_main = new BarcodeIFMdata(1);
    //private BarcodeIFMdata BarcodeIFMdata_backup = new BarcodeIFMdata(2);
    private string _guid = "";
    private string _counter_id = "";


    private const string ID_TEXT = "Box ID";

    public BarcodeUC()
    {
      InitializeComponent();
      //
#if USING_USB_BARCODE
      timer1 = new Timer();
      timer1.Interval = 200;
      timer1.Tick += new EventHandler(timer1_Tick);
#endif
      //
      //timer2 = new Timer();
      //timer2.Interval = 200;
      //timer2.Tick += new EventHandler(timer2_Tick);
      //
      MakeFocusToBarcodeScanner();
    }

    public void DeInit()
    {
      //barcodeIFM1.DeInit();
    }

    public void Init(string barcodeIFM_COM, int barcodeIFM_id)
    {
      _barcodeIFM_COM = barcodeIFM_COM;
      _barcodeIFM_id = barcodeIFM_id;
      //
      //barcodeIFM1.Init(barcodeIFM_COM, 9600, 8, Parity.None, StopBits.One, MASTER_SLAVE.SLAVE, barcodeIFM_id);
    }

    public string GetBarcodeIFMbyText()
    {
      return txtBarcodeScanner_IFM.Text;
    }

    public void SetBarcodeTextData(string barcode_data)
    {
      this.txtBarcodeScanner_IFM.Text = barcode_data;
    }

    public string GetBarcode_GIUD()
    {
      return _guid;
    }

    public string GetBarcode_counter_id()
    {
      return _counter_id;
    }
    
    public void SetBarcode_counter_id(string counter_id)
    {
      _counter_id = counter_id;
      label3.Text = String.Format("{0}:{1}", ID_TEXT, _counter_id);
    }


    public void ClearBarcodeIFM()
    {
      if (txtBarcodeScanner_IFM.Text != "")  txtBarcodeScanner_Backup.Text = txtBarcodeScanner_IFM.Text;
      txtBarcodeScanner_IFM.Text = "";
      _guid = createtGUID();
      nReadCount = 0;
    }
      

    public void MakeFocusToBarcodeScanner()
    {
      this.ActiveControl = txtBarcodeScanner_Backup;
      txtBarcodeScanner_Backup.Focus();
      txtBarcodeScanner_Backup.SelectAll();      
    }
    public void MakeFocusToBarcodeScanner(bool IsResetText)
    {
      if (this.ActiveControl != txtBarcodeScanner_Backup)
      {
        this.ActiveControl = txtBarcodeScanner_Backup;
        if (IsResetText == true)
        {
          txtBarcodeScanner_Backup.Text = "";
        }
        else
        {
        }
        txtBarcodeScanner_Backup.Focus();
        txtBarcodeScanner_Backup.SelectAll();
      }
    }

    public void SetPosition(Point indicator_location, int indicator_location_width)
    {
      int indicator_location_X = indicator_location.X;
      int indicator_location_Y = indicator_location.Y;

      this.Location = new Point(indicator_location_X + indicator_location_width + 10, indicator_location_Y);
    }

    public void SetupBarcode(List<BarcodeScannerType> list_barcode_scanner)
    {
#if USING_USB_BARCODE
      _list_barcode_scanner = list_barcode_scanner;


      refreshDeviceList_BarcodeScanner();

      Barcode_Add_Hook_Keys();

      KeysHookReader.Clear();
      //if (IsConnect == true)
      {
        //setup actHook;
        actHook = new UserActivityHook(); // crate an instance with global hooks
        // hang on events
        //actHook.OnMouseActivity+=new MouseEventHandler(MouseMoved);
        //actHook.KeyDown+=new KeyEventHandler(MyKeyDown);
        //actHook.KeyPress+=new KeyPressEventHandler(MyKeyPress);
        actHook.KeyUp += new KeyEventHandler(MyKeyUp);
      }
#else
     
      
#endif 
    }
    public void SetupBarcode(string barcode_VID, string barcode_PID)
    {
#if USING_USB_BARCODE
      //parsing VID
      if (barcode_VID != "")
      {
        try
        {
          //Decimal aaa = Decimal.Parse(barcode_VID);
          string barcode_VID_str = barcode_VID.Replace("x", string.Empty);
          VID = ushort.Parse(barcode_VID_str, System.Globalization.NumberStyles.HexNumber);
          //VID = ushort.Parse(barcode_VID);          
        }
        catch
        {
        }
      }
      //parsing PID
      if (barcode_PID != "")
      {
        try
        {
          PID = ushort.Parse(barcode_PID);
        }
        catch
        {
        }
      }
      
      refreshDeviceList();

      //
      Barcode_Add_Hook_Keys();

      KeysHookReader.Clear();
      if (IsConnect == true)
      {
        //setup actHook;
        actHook = new UserActivityHook(); // crate an instance with global hooks
        // hang on events
        //actHook.OnMouseActivity+=new MouseEventHandler(MouseMoved);
        //actHook.KeyDown+=new KeyEventHandler(MyKeyDown);
        //actHook.KeyPress+=new KeyPressEventHandler(MyKeyPress);
        actHook.KeyUp += new KeyEventHandler(MyKeyUp);
      }
      else
      {
        /* do nothing */
      }
#endif
    }
    public void UpdateListBarcode(List<BarcodeScannerType> list_barcode_scanner)
    {
      _list_barcode_scanner = list_barcode_scanner;
    }
    public void SetConnect(bool IsConnectDisconnect)
    {
      if (IsConnectDisconnect == true)
      {
        if (actHook == null)
        {
          //actHook = new UserActivityHook();
          //actHook.KeyUp += new KeyEventHandler(MyKeyUp);
        }
        else
        {
          /* do nothing */
        }

        IsConnect = true;
      }
      else
      {
        IsConnect = false;
      }
      if (OnBarcodeUSBConnect != null)
      {
        OnBarcodeUSBConnect(this, IsConnect, _list_barcode_scanner);
      }
    }
    private void refreshDeviceList_BarcodeScanner()
    {
      //cboDevices.SelectedIndexChanged -= cboDevices_SelectedIndexChanged;
      try
      {
        mDevList = UsbGlobals.DeviceList;
        bool IsDeviceConnect = false;
        for (int j = 0; (j < _list_barcode_scanner.Count); j++)
        {
          /* found from usb_device */
          bool IsExit = false;
          for (int i = 0; (i < mDevList.Count) && (IsExit == false); i++)
          {
            UsbDevice device = mDevList[i];
            string device_infor_VID = String.Format("0x{0}", device.Info.IdVendor.ToString("X").PadLeft(4, '0'));
            string device_infor_PID = String.Format("0x{0}", device.Info.IdProduct.ToString("X").PadLeft(4, '0'));
            if ((device_infor_VID == _list_barcode_scanner[j].VID) && (device_infor_PID == _list_barcode_scanner[j].PID))
            {
              IsExit = true;
            }
            else
            {

            }
          }
          if (IsExit == true)
          {
            _list_barcode_scanner[j].Status = "CONNECT";
          }
          else
          {
            _list_barcode_scanner[j].Status = "DISCONNECT";
          }
          IsDeviceConnect |= IsExit;

        }

        /* found device ==> set connect */
        if (IsDeviceConnect == true)
        {
          IsConnect = true;
        }

        /* notify connected */
        if (OnBarcodeUSBConnect != null)
        {
          OnBarcodeUSBConnect(this, IsConnect, _list_barcode_scanner);
        }
      }
      catch
      {
      }
    }


    private void refreshDeviceList()
    {
      //cboDevices.SelectedIndexChanged -= cboDevices_SelectedIndexChanged;
      mDevList = UsbGlobals.DeviceList;
      bool IsExit = false;
      for (int i = 0; (i < mDevList.Count) && (IsExit == false); i++)
      {
        UsbDevice device = mDevList[i];
        if ((device.Info.IdVendor == VID) && (device.Info.IdProduct == PID))
        {
          IsExit = true;
        }
      }
      if (IsExit == true)
      {
        IsConnect = true;
      }

      if (OnBarcodeUSBConnect != null)
      {
        OnBarcodeUSBConnect(this, IsConnect, _list_barcode_scanner);
      }
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
      timer1.Enabled = false;
      string barcode_data = "";
      if (IsInProgress == false)
      {
        IsInProgress = true;
      }
      //
      if (OnFlushData != null)
      {
        if ((IsInProgress == true) && (KeysHookReader.Count > 0))// && (IsConnect == true))
        {
          for (int i = 0; i < KeysHookReader.Count; i++)
          {
            barcode_data += ConvertKeyToString(KeysHookReader[i]);
          }
          //clear before sending
          KeysHookReader.Clear();
          if (barcode_data.Length > MAX_BARCODE_LENGTH_ENABLE)
          {
            OnFlushData(this, barcode_data);
          }
          barcode_data = "";
          IsInProgress = false;
        }
      }
    }


    public void MyKeyUp(object sender, KeyEventArgs e)
    {
      if (IsInProgress == false)
      {
        if ((KeysHook.Contains(e.KeyData)))
        {
          KeysHookReader.Add(e.KeyData);
          //
          timer1.Enabled = false;
          timer1.Enabled = true;
        }
      }
      else
      {
        /* In process, not collect data */
      }
    }
    private string ConvertKeyToString(Keys key)
    {
      string key_as_string = "";
      if ((key == Keys.D0) || (key == Keys.NumPad0)) key_as_string = "0";
      else if ((key == Keys.D1) || (key == Keys.NumPad1)) key_as_string = "1";
      else if ((key == Keys.D2) || (key == Keys.NumPad2)) key_as_string = "2";
      else if ((key == Keys.D3) || (key == Keys.NumPad3)) key_as_string = "3";
      else if ((key == Keys.D4) || (key == Keys.NumPad4)) key_as_string = "4";
      else if ((key == Keys.D5) || (key == Keys.NumPad5)) key_as_string = "5";
      else if ((key == Keys.D6) || (key == Keys.NumPad6)) key_as_string = "6";
      else if ((key == Keys.D7) || (key == Keys.NumPad7)) key_as_string = "7";
      else if ((key == Keys.D8) || (key == Keys.NumPad8)) key_as_string = "8";
      else if ((key == Keys.D9) || (key == Keys.NumPad9)) key_as_string = "9";
      //
      else if (key == Keys.A) key_as_string = "A";
      else if (key == Keys.B) key_as_string = "B";
      else if (key == Keys.C) key_as_string = "C";
      else if (key == Keys.D) key_as_string = "D";
      else if (key == Keys.E) key_as_string = "E";
      else if (key == Keys.F) key_as_string = "F";
      else if (key == Keys.G) key_as_string = "G";
      else if (key == Keys.H) key_as_string = "H";
      else if (key == Keys.I) key_as_string = "I";
      else if (key == Keys.J) key_as_string = "J";
      else if (key == Keys.K) key_as_string = "K";
      else if (key == Keys.L) key_as_string = "L";
      else if (key == Keys.M) key_as_string = "M";
      else if (key == Keys.N) key_as_string = "N";
      else if (key == Keys.O) key_as_string = "O";
      else if (key == Keys.P) key_as_string = "P";
      else if (key == Keys.Q) key_as_string = "Q";
      else if (key == Keys.R) key_as_string = "R";
      else if (key == Keys.S) key_as_string = "S";
      else if (key == Keys.T) key_as_string = "T";
      else if (key == Keys.U) key_as_string = "U";
      else if (key == Keys.V) key_as_string = "V";
      else if (key == Keys.X) key_as_string = "X";
      else if (key == Keys.Y) key_as_string = "Y";
      else if (key == Keys.Z) key_as_string = "Z";
      //
      else if (key == Keys.Add) key_as_string = "+";
      else if (key == Keys.Separator) key_as_string = "_";
      else if (key == Keys.Subtract) key_as_string = "-";
      else if (key == Keys.Decimal) key_as_string = ".";
      else if (key == Keys.Divide) key_as_string = "/";
      //
      else if (key == Keys.OemMinus) key_as_string = "-";
      return key_as_string;
    }


    private void Barcode_Add_Hook_Keys()
    {
      KeysHook.Clear();
      KeysHook.Add(Keys.D0);
      KeysHook.Add(Keys.D1);
      KeysHook.Add(Keys.D2);
      KeysHook.Add(Keys.D3);
      KeysHook.Add(Keys.D4);
      KeysHook.Add(Keys.D5);
      KeysHook.Add(Keys.D6);
      KeysHook.Add(Keys.D7);
      KeysHook.Add(Keys.D8);
      KeysHook.Add(Keys.D9);
      //
      KeysHook.Add(Keys.NumPad0);
      KeysHook.Add(Keys.NumPad1);
      KeysHook.Add(Keys.NumPad2);
      KeysHook.Add(Keys.NumPad3);
      KeysHook.Add(Keys.NumPad4);
      KeysHook.Add(Keys.NumPad5);
      KeysHook.Add(Keys.NumPad6);
      KeysHook.Add(Keys.NumPad7);
      KeysHook.Add(Keys.NumPad8);
      KeysHook.Add(Keys.NumPad9);
      //
      KeysHook.Add(Keys.A);
      KeysHook.Add(Keys.B);
      KeysHook.Add(Keys.C);
      KeysHook.Add(Keys.D);
      KeysHook.Add(Keys.E);
      KeysHook.Add(Keys.F);
      KeysHook.Add(Keys.G);
      KeysHook.Add(Keys.H);
      KeysHook.Add(Keys.I);
      KeysHook.Add(Keys.J);
      KeysHook.Add(Keys.K);
      KeysHook.Add(Keys.L);
      KeysHook.Add(Keys.M);
      KeysHook.Add(Keys.N);
      KeysHook.Add(Keys.O);
      KeysHook.Add(Keys.P);
      KeysHook.Add(Keys.Q);
      KeysHook.Add(Keys.R);
      KeysHook.Add(Keys.S);
      KeysHook.Add(Keys.T);
      KeysHook.Add(Keys.U);
      KeysHook.Add(Keys.V);
      KeysHook.Add(Keys.W);
      KeysHook.Add(Keys.X);
      KeysHook.Add(Keys.Y);
      KeysHook.Add(Keys.Z);
      //
      KeysHook.Add(Keys.Add);
      KeysHook.Add(Keys.Separator);
      KeysHook.Add(Keys.Subtract);
      KeysHook.Add(Keys.Decimal);
      KeysHook.Add(Keys.Divide);
      //
      KeysHook.Add(Keys.OemMinus);
    }
    
    

  
    

    public class BarcodeScannerType
    {
      public string id = "";
      public string VID = "";
      public string PID = "";
      public string Status = "";

    }

    public class BarcodeIFMdata
    {
      public int id;
      public string barcode_data = "";
      public string GUID = "";

      public BarcodeIFMdata(int idx)
      {
        id = idx;
      }
    }

    private string createtGUID()
    {
      string ret = DateTime.Now.ToString("yyMMddHHmmssffff");
      return ret;
    }
    
  }
}
