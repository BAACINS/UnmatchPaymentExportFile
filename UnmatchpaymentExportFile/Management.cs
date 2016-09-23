using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnmatchpaymentExportFile
{
    class Management
    {
        public void CreateDirectory(string strPathFile)
        {
            try
            {
                if (!System.IO.File.Exists(strPathFile))
                {
                    System.IO.Directory.CreateDirectory(strPathFile);
                }
                else
                {
                    Console.WriteLine("Deleted File already exists.");
                    return;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string GetSystemTimeSPIN()
        {
            CultureInfo us = System.Globalization.CultureInfo.GetCultureInfo("en-US");
            string strDate = string.Empty;
            strDate = DateTime.Now.ToString("yyyyMMdd", us);
            return strDate;
        }

        public string GetSystemTimeGL() //yyyyMMdd CE
        {
            CultureInfo us = System.Globalization.CultureInfo.GetCultureInfo("en-US");
            string strDate = string.Empty;
            strDate = DateTime.Now.AddDays(1).ToString("yyyyMMdd", us);
            return strDate;
        }

        public DataSet GetDataFromStored(string ProcedureName)
        {
            DataSet _dsGL = new DataSet();

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

        public void UpdateMatchinfID()
        {
            try
            {
                string ProcedureName = ConfigurationSettings.AppSettings["UpdateMatchingID"].ToString();//"[UP].[SP_UpdateMatchingID]"; 
                Connection Sqlcon = new Connection();
                SqlConnection SqlConn = Sqlcon.open();
                //SqlDataAdapter adapter;
                SqlCommand command = new SqlCommand();
                command.CommandTimeout = int.Parse(ConfigurationSettings.AppSettings["TimeOut"].ToString());
                command.Connection = SqlConn;
                command.CommandType = CommandType.StoredProcedure;

                //command.CommandText = "[dbo].[MIS_CUSTOMER_ACCT_INFO_D]";
                command.CommandText = ProcedureName;
                command.ExecuteNonQuery();

                //adapter = new SqlDataAdapter(command);
                //adapter.Fill(_dsSPIN);
            }
            catch (Exception ex)
            {
                //throw ex;
            }
        }
    }
}
