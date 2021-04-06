using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace WinFormsApp1
{
    class Logger
    {
        public void LogError (string msg)
        {
            using (StreamWriter sw = new StreamWriter(Environment.CurrentDirectory + "\\log.txt", true))
            {
                sw.WriteLine(DateTime.Today.ToString("dd.MM.yyyy") + "_" + DateTime.Now.ToString("HH:mm:ss_") + msg);
            }
        }
    }
}
