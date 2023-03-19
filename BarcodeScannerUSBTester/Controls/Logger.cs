using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
//using System.ServiceProcess;
using System.Text;
//using System.Threading.Tasks;
using System.Timers;
using System.Configuration;
using System.Collections.Specialized;
using MqttLib;
using Newtonsoft.Json;
//using System.Security.RightsManagement;
//using BarcodeReaderTCPs.Controls;
using System.Windows.Forms;
namespace BarcodeScannerUsbUtility.Controls
{
  public class Logger
  {
    public string Title = "Logger";
    public string Message;
    public string Time;
    public static void WriteToLogFile(string message, string title = "Logger")
    {
      try
      {
        string path = AppDomain.CurrentDomain.BaseDirectory + "\\Logs";
        var logs = new Logger() { Title = title, Message = message, Time = DateTime.Now.ToString() };
        string _message = JsonConvert.SerializeObject(logs);

        if (!Directory.Exists(path))
        {
          Directory.CreateDirectory(path);
        }
        string filepath = AppDomain.CurrentDomain.BaseDirectory + "\\Logs\\ServiceLog_" + DateTime.Now.Date.ToShortDateString().Replace('/', '_') + ".txt";
        if (!File.Exists(filepath))
        {
          // Create a file to write to. 
          using (StreamWriter sw = File.CreateText(filepath))
          {
            sw.WriteLine(_message);
          }
        }
        else
        {
          using (StreamWriter sw = File.AppendText(filepath))
          {
            sw.WriteLine(_message);
          }
        }
      }
      catch
      { }
    }
    public void WriteToLogFile(string message)
    {
      WriteToLogFile(message, Title);
    }
    public void WriteErrorLog(string msg, bool isNotify = true)
    {
      WriteToLogFile(msg, "Error!");
      if (isNotify)
        MessageBox.Show(msg, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }
    public void WriteErrorLog(Exception ex, bool isNotify = true)
    {
      WriteToLogFile(ex.Message, "Error!");
      if (isNotify)
        MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }
  }
}
