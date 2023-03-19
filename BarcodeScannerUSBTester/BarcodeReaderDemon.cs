using System;
using System.Timers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using barcode;
using LibUsbDotNet.DeviceNotify;
using LibUsbDotNet.Usb;
using LibUsbDotNet.Usb.Main;
using System.Windows.Forms;
//using System.Console;

namespace BarcodeScannerUsbUtility
{
    public class BarcodeReaderDemon
    {
        private barcode.BarcodeUC barcode_reader = new barcode.BarcodeUC();

        #region Variable
        private DeviceNotifier mDevNotifier;
        #region Nested type: DeviceNotifyEventDelegate
        private delegate void DeviceNotifyEventDelegate(object sender, DeviceNotifyEventArgs e);
        #endregion

        private LibUsbDotNet.DeviceNotify.Info.UsbDeviceNotifyInfo usb_device = null;
        private EventType usb_event_type = EventType.CUSTOMEVENT;

        private System.Timers.Timer timer_barcode_Notify = new System.Timers.Timer();

        private string my_barcode_VID = "0x0C2E";
        private string my_barcode_PID = "0x0901";
        #endregion
        Action<string> WriteTologs = Console.WriteLine;
        public BarcodeReaderDemon()
        {
            
        }
        public void Init()
        {
            timer_barcode_Notify.Interval = 1000;
            //timer_barcode_Notify.Tick += new EventHandler(timer_barcode_Notify_Tick);
            timer_barcode_Notify.Elapsed += Timer_barcode_Notify_Elapsed;

            mDevNotifier = new DeviceNotifier();
            mDevNotifier.OnDeviceNotify += new EventHandler<DeviceNotifyEventArgs>(mDevNotifier_OnDeviceNotify);
            barcode_reader.OnFlushData += new barcode.BarcodeUC.FlushData(barcode_reader_OnFlushData); //new BarcodeUC.FlushData(barcode_reader_OnFlushData);
            barcode_reader.OnBarcodeUSBConnect += new BarcodeUC.BarcodeUSBConnect(barcode_reader_OnBarcodeUSBConnect);


            /* ************* setup barcode scanner **************/
            List<barcode.BarcodeUC.BarcodeScannerType> list_barcode_scanner = ConvertListBarcodeScanner();
            barcode_reader.SetupBarcode(list_barcode_scanner);

            this.barcode_reader.MakeFocusToBarcodeScanner(false);
        }

        private void Timer_barcode_Notify_Elapsed(object sender, ElapsedEventArgs e)
        {
            timer_barcode_Notify.Enabled = false;
            try
            {
                //bool IsExitLoop = false;
                string device_infor_VID = String.Format("0x{0}", usb_device.IdVendor.ToString("X").PadLeft(4, '0'));
                string device_infor_PID = String.Format("0x{0}", usb_device.IdProduct.ToString("X").PadLeft(4, '0'));
                bool IsFoundCorrectBarcode = false;
                if ((device_infor_VID == my_barcode_VID) && (device_infor_PID == my_barcode_PID))
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
                    //this.panel1.BackColor = Color.Red;
                }
                else
                {
                    this.barcode_reader.SetConnect(true);
                    //this.panel1.BackColor = Color.Green;
                }
            }
            catch
            {
            }
        }

        private List<BarcodeUC.BarcodeScannerType> ConvertListBarcodeScanner()
        {
            List<BarcodeUC.BarcodeScannerType> list_barcode_scanner = new List<BarcodeUC.BarcodeScannerType>();
            //BarcodeUC.BarcodeScannerType my_barcode_usb = new BarcodeUC.BarcodeScannerType();
            BarcodeUC.BarcodeScannerType barcode = new BarcodeUC.BarcodeScannerType();
            barcode.id = "1";
            barcode.VID = "0x0C2E";
            barcode.PID = "0x0901";
            //add to list
            list_barcode_scanner.Add(barcode);
            return list_barcode_scanner;
        }

        private void barcode_reader_OnBarcodeUSBConnect(object sender, bool IsConnect, List<BarcodeUC.BarcodeScannerType> list_barcode_scanner)
        {
            if (IsConnect == false)
            {
                //this.panel1.BackColor = Color.Red;//.SetConnect_Barcode(DataTypes.COMM_STATUS.DISCONNECT);
            }
            else
            {
                //this.panel1.BackColor = Color.Green;//communicationStatusByLed1.SetConnect_Barcode(DataTypes.COMM_STATUS.CONNECT);
            }
        }

        private void barcode_reader_OnFlushData(object sender, string data)
        {
            //xy ly day data
        }

        private void mDevNotifier_OnDeviceNotify(object sender, DeviceNotifyEventArgs e)
        {
            //Invoke(new DeviceNotifyEventDelegate(OnDevNotify), new object[] { sender, e });
        }

        private void OnDevNotify(object sender, DeviceNotifyEventArgs e)
        {
            object[] o = new object[] { e.EventType.ToString(), DateTime.Now.ToString(), e.DeviceType.ToString(), e.Object.ToString() };
            string s = String.Format("{0} - Time: {1}  -  {2}\r\n{3}", o);

            if (e.DeviceType == DeviceType.DEVICEINTERFACE && e.EventType == EventType.DEVICEARRIVAL)
                s += "\r\n" + e.Device.SymbolicName.FullName;
            //tNotify.Text += s;
            // MessageBox.Show(s);
            //DeviceType 
            usb_device = e.Device;
            usb_event_type = e.EventType;
            timer_barcode_Notify.Enabled = true;
        }
    }
}
