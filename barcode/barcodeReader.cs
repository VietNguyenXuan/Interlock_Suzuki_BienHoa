using System;
using System.Collections.Generic;
using System.Text;
using gma.System.Windows;
using System.Windows.Forms;
using LibUsbDotNet.Usb;
using LibUsbDotNet.Usb.Main;
using LibUsbDotNet.DeviceNotify;
using System.Diagnostics;

namespace barcode
{
  
  public class barcodeReader
  {
    public delegate void FlushData(object sender, string data);
    public event FlushData OnFlushData;

    public delegate void BarcodeConnect(object sender);
    public event BarcodeConnect OnBarcodeConnect;

    private UserActivityHook actHook;
    private List<Keys> KeysHook = new List<Keys>();
    
    private List<Keys> KeysHookReader = new List<Keys>();

    private Timer timer1;

    private bool IsConnect = false;

    private const ushort VID = 0x0C2E;
    private const ushort PID = 0x0204;

    private UsbDeviceList mDevList;
    private UsbDevice mDev;
    private UsbEndpointWriter mEpWriter;
    private UsbEndpointReader mEpReader;

    private DeviceNotifier mDevNotifier;
    #region Nested type: DeviceNotifyEventDelegate

    private delegate void DeviceNotifyEventDelegate(object sender, DeviceNotifyEventArgs e);

    #endregion

    public barcodeReader()
    {
      
    }
    public void SetupBarcode()
    {
      timer1 = new Timer();
      timer1.Interval = 300;
      timer1.Tick += new EventHandler(timer1_Tick);

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
        if (OnBarcodeConnect != null)
        {
          OnBarcodeConnect(this);
        }
        //
        IsConnect = true;
      }
        //foreach (UsbDevice device in mDevList)
        //{
        //  string sAdd = string.Format("Vid:0x{0:X4} Pid:0x{1:X4} {2} {3} {4}", device.Info.IdVendor, device.Info.IdVendor, device.Info.ManufacturerString, device.Info.ProductString, device.Info.SerialString);
        //  //cboDevices.Items.Add(sAdd);
        //  int mm = 0;
        //}
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
      timer1.Enabled = false;
      string barcode_data = "";
      if (OnFlushData != null)
      {
        if (KeysHookReader.Count > 0)
        {
          for (int i = 0; i < KeysHookReader.Count; i++)
          {
            barcode_data += ConvertKeyToString(KeysHookReader[i]);
          }
          OnFlushData(this, barcode_data);
        }
      }
      KeysHookReader.Clear();
      //Console.WriteLine(String.Format("Test {0}", barcode_data));
      //private string barcode_data = "";
      //if (OnFlushData != null)
      //{
      //  if (KeysHookReader.Le != "")
      //  {
      //    OnFlushData(this, barcode_data);
      //  }
      //}
      //KeysHookReader.Clear();
      //barcode_data = "";
    }
    public void MyKeyUp(object sender, KeyEventArgs e)
    {
      //LogWrite("KeyUp 		- " + e.KeyData.ToString());
      if (KeysHook.Contains(e.KeyData))
      {
        KeysHookReader.Add(e.KeyData);

        //barcode_data += e.KeyData.ToString();
        timer1.Enabled = false;
        timer1.Enabled = true;
      }
    }
    private string ConvertKeyToString(Keys key)
    {
      string key_as_string = "";
      if (key == Keys.D0) key_as_string = "0";
      else if (key == Keys.D1) key_as_string = "1";
      else if (key == Keys.D2) key_as_string = "2";
      else if (key == Keys.D3) key_as_string = "3";
      else if (key == Keys.D4) key_as_string = "4";
      else if (key == Keys.D5) key_as_string = "5";
      else if (key == Keys.D6) key_as_string = "6";
      else if (key == Keys.D7) key_as_string = "7";
      else if (key == Keys.D8) key_as_string = "8";
      else if (key == Keys.D9) key_as_string = "9";
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
      else if (key == Keys.OemMinus) key_as_string = "-";
      return key_as_string;
    }
    private void Barcode_Add_Hook_Keys()
    {
      KeysHook.Clear();
      KeysHook.Add(Keys.D0); KeysHook.Add(Keys.D1);
      KeysHook.Add(Keys.D2); KeysHook.Add(Keys.D3);
      KeysHook.Add(Keys.D4); KeysHook.Add(Keys.D5);
      KeysHook.Add(Keys.D6); KeysHook.Add(Keys.D7);
      KeysHook.Add(Keys.D8); KeysHook.Add(Keys.D9);
      //
      KeysHook.Add(Keys.A); KeysHook.Add(Keys.B);
      KeysHook.Add(Keys.C); KeysHook.Add(Keys.D);
      KeysHook.Add(Keys.E); KeysHook.Add(Keys.F);
      KeysHook.Add(Keys.G); KeysHook.Add(Keys.H);
      KeysHook.Add(Keys.I); KeysHook.Add(Keys.J);
      KeysHook.Add(Keys.K); KeysHook.Add(Keys.L);
      KeysHook.Add(Keys.M); KeysHook.Add(Keys.N);
      KeysHook.Add(Keys.O); KeysHook.Add(Keys.P);
      KeysHook.Add(Keys.Q);
      KeysHook.Add(Keys.R); KeysHook.Add(Keys.S);
      KeysHook.Add(Keys.T); KeysHook.Add(Keys.U);
      KeysHook.Add(Keys.V); KeysHook.Add(Keys.W);
      KeysHook.Add(Keys.X); KeysHook.Add(Keys.Y);
      KeysHook.Add(Keys.Z);
      //
      KeysHook.Add(Keys.OemMinus);
    }
  }
}
