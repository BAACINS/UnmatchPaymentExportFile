using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace UnmatchpaymentExportFile
{
    class SPIN
    {
        Management Mng = new Management();
        string strPathFile = ConfigurationSettings.AppSettings["PathFileSPIN"].ToString();
        string strFileName = ConfigurationSettings.AppSettings["FileSPINName"].ToString();
        LogFile Log = new LogFile();
        public DataSet GetDataSPIN()
        {
            DataSet _dsSPIN = new DataSet();
            string ProcedureName = ConfigurationSettings.AppSettings["StoredSPINExport"].ToString();

            //DataTable _dt = new DataTable();
            try
            {
                Connection Sqlcon = new Connection();
                SqlConnection SqlConn = Sqlcon.open();
                SqlDataAdapter adapter;
                SqlCommand command = new SqlCommand();
                command.CommandTimeout = int.Parse(ConfigurationSettings.AppSettings["TimeOut"].ToString());
                command.Connection = SqlConn;
                command.CommandType = CommandType.StoredProcedure;

                //command.CommandText = "[dbo].[MIS_CUSTOMER_ACCT_INFO_D]";
                command.CommandText = ProcedureName;
                adapter = new SqlDataAdapter(command);
                adapter.Fill(_dsSPIN);
            }
            catch (Exception ex)
            {
                //throw ex;
            }

            return _dsSPIN;
        }
        public void ExportSPIN()
        {
            //GetDataSPIN();

            try
            {
                //Drirectory Manage
                //string strPathFile = ConfigurationSettings.AppSettings["PathFileSPIN"].ToString();
                Mng.CreateDirectory(strPathFile);
                string FileName = strFileName + Mng.GetSystemTimeSPIN(); //set file name
                
                File.Delete(strPathFile + "\\" + FileName);  //Delate File
                //Create File
                File.AppendAllText(strPathFile + "\\" + FileName, "", Encoding.GetEncoding(874));

                Log.WriteLog("Start :" + strFileName + " - " + DateTime.Now.ToString());
                Console.WriteLine(strFileName + " - " + DateTime.Now);
                
                //Export File
                DataSet _ds = Mng.GetDataFromStored(ConfigurationSettings.AppSettings["StoredSPINExport"].ToString());
                DataTable _dtHeader = _ds.Tables[0];
                DataTable _dtRecord = _ds.Tables[1];
                DataTable _dtTotal = _ds.Tables[2];
                //Header
                for (int i = 0; i < _dtHeader.Rows.Count && _dtRecord.Rows.Count > 0; i++)
                {
                    string strRec = string.Empty;
                    DataRow dr = _dtHeader.Rows[i];
                    for (int j = 0; j < _dtHeader.Columns.Count; j++)
                    {
                        strRec += dr.ItemArray[j].ToString();
                    }
                    File.AppendAllText(strPathFile + "\\" + FileName, strRec + Environment.NewLine, Encoding.GetEncoding(874));
                }
                //Record
                for (int i = 0; i < _dtRecord.Rows.Count; i++)
                {
                    string strRec = string.Empty;
                    DataRow dr = _dtRecord.Rows[i];
                    for (int j = 0; j < _dtRecord.Columns.Count; j++)
                    {
                        strRec += dr.ItemArray[j].ToString();
                    }
                    File.AppendAllText(strPathFile + "\\" + FileName, strRec + Environment.NewLine, Encoding.GetEncoding(874));
                }
                //Total
                for (int i = 0; i < _dtTotal.Rows.Count && _dtRecord.Rows.Count > 0; i++)
                {
                    string strRec = string.Empty;
                    DataRow dr = _dtTotal.Rows[i];
                    for (int j = 0; j < _dtTotal.Columns.Count; j++)
                    {
                        strRec += dr.ItemArray[j].ToString();
                    }
                    File.AppendAllText(strPathFile + "\\" + FileName, strRec + Environment.NewLine, Encoding.GetEncoding(874));
                }

                Log.WriteLog("Finished :" + strFileName + " - " + DateTime.Now.ToString());
            }
            catch (Exception ex)
            {
                Log.WriteError(ex.Message);
                Console.WriteLine("error :", strFileName + " : " + ex.Message + " - " + DateTime.Now.ToString());
            }
        }
    }
}
