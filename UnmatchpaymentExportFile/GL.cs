using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnmatchpaymentExportFile
{
    class GL
    {
        Management Mng = new Management();
        string strPathFile = ConfigurationSettings.AppSettings["PathFileGL"].ToString();
        string strFileName = ConfigurationSettings.AppSettings["FileGLName"].ToString();
        LogFile Log = new LogFile();
        public DataSet GetDataGL()
        {
            DataSet _dsGL = new DataSet();
            string ProcedureName = ConfigurationSettings.AppSettings["StoredGLExport"].ToString();

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
                adapter.Fill(_dsGL);
            }
            catch (Exception ex)
            {
                //throw ex;
            }

            return _dsGL;
        }

        public void ExportGL()
        {
            //GetDataSPIN();

            try
            {
                //Drirectory Manage
                
                Mng.CreateDirectory(strPathFile);
                string FileName = strFileName + Mng.GetSystemTimeGL() ; //set file name

                File.Delete(strPathFile + "\\" + FileName);  //Delate File
                //Create File
                File.AppendAllText(strPathFile + "\\" + FileName, "", Encoding.GetEncoding(874));

                Log.WriteLog("Start :" + strFileName + " - " + DateTime.Now.ToString());
                Console.WriteLine(strFileName + " - " + DateTime.Now);

                //Export File
                DataSet _ds = Mng.GetDataFromStored(ConfigurationSettings.AppSettings["StoredGLExport"].ToString());
                DataTable _dtDetail = _ds.Tables[0];
                DataTable _dtControl = _ds.Tables[1];
                //DETAIL_RECORD
                for (int i = 0; i < _dtDetail.Rows.Count; i++)
                {
                    string strRec = string.Empty;
                    DataRow dr = _dtDetail.Rows[i];
                    for (int j = 0; j < _dtDetail.Columns.Count; j++)
                    {
                        strRec += dr.ItemArray[j].ToString();
                    }
                    File.AppendAllText(strPathFile + "\\" + FileName, strRec + Environment.NewLine, Encoding.GetEncoding(874));
                }
                //CONTROL_RECORD
                for (int i = 0; i < _dtControl.Rows.Count; i++)
                {
                    string strRec = string.Empty;
                    DataRow dr = _dtControl.Rows[i];
                    for (int j = 0; j < _dtControl.Columns.Count; j++)
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
