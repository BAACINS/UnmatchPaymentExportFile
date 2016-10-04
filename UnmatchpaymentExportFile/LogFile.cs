using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnmatchpaymentExportFile
{
    class LogFile
    {
        string strPath = ConfigurationSettings.AppSettings["PathLogs"].ToString();
        public void WriteError(string strError)
        {
            if (!Directory.Exists(strPath))
            {
                Directory.CreateDirectory(strPath);
            }

            try
            {
                File.AppendAllText(strPath + "\\Log_" + DateTime.Now.ToString("yyyyMMdd") + ".txt", "Error_" + DateTime.Now + " : " + strError + Environment.NewLine);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message + Environment.NewLine);
            }
        }

        public void WriteLog(string strLog)
        {
            if (!Directory.Exists(strPath))
            {
                Directory.CreateDirectory(strPath);
            }

            try
            {
                File.AppendAllText(strPath + "Log_" + DateTime.Now.ToString("yyyyMMdd") + ".txt", "Log_" + DateTime.Now + " : " + strLog + Environment.NewLine);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message + Environment.NewLine);
            }
        }
    }
}
