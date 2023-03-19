using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Configuration;
using System.Net.NetworkInformation;

namespace BarcodeScannerUsbUtility.Controls
{
  public class CONFIG
  {
    object appSettings = ConfigurationManager.AppSettings;
     static Logger logger = new Logger();
    public static void Init()
    {
      //ConfigurationManager.
    }
    public static void ReadAllSettings()
    {
      try
      {
        var appSettings = ConfigurationManager.AppSettings;

        if (appSettings.Count == 0)
        {
          Console.WriteLine("AppSettings is empty.");
          logger.WriteToLogFile("AppSettings is empty.");
        }
        else
        {
          appSettings["PID"] = "";
        }
      }
      catch (ConfigurationErrorsException)
      {
        Console.WriteLine("Error reading app settings");
      }
    }
    public static string ReadSetting(string key)
    {
      string result = "";
      try
      {
        var appSettings = ConfigurationManager.AppSettings;
        result = appSettings[key] ?? "Not Found";

      }
      catch (ConfigurationErrorsException)
      {
        Console.WriteLine("Error reading app settings");
      }
      return result;
    }//READ VALUE FROM FILE CONFIG

    public static void UpdateAppSettings(string key, string value)
    {

      try
      {
        var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        var settings = configFile.AppSettings.Settings;
        if (settings[key] == null)
        {
          settings.Add(key, value);
        }
        else
        {
          settings[key].Value = value;
        }
        configFile.Save(ConfigurationSaveMode.Modified);
        ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
      }
      catch (ConfigurationErrorsException)
      {
        Console.WriteLine("Error writing app settings");
      }
    }//UPDATE FILE CONFIG

  }
}
