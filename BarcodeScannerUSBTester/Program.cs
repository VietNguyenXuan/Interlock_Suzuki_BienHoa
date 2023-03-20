using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BarcodeScannerUsbUtility
{
  static class Program
  {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main(string[] args)
    {
      //FormMain formMain = FormMain.CreateInstance(args);
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run(FormMain.Instance());

      ////Application.Run(new FormMain());
      //Application.Run(FormMain.Instance());
      //Application.Run(new FormSystemConFig());
      //Application.Run(new FormChangePass());
      //Application.Run(new FormGeneralConFig());
      //Application.Run(new FormLogin());



    }
  }
}
