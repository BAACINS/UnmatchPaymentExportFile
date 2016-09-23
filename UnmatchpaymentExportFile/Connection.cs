using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnmatchpaymentExportFile
{
    class Connection
    {
        public String Server = ConfigurationSettings.AppSettings["DBServer"].ToString();//"alluat";
        public String SqlDatabaseName = ConfigurationSettings.AppSettings["DBName"].ToString();
        public String SqlUser = ConfigurationSettings.AppSettings["DBUserID"].ToString();
        public String SqlPassword = ConfigurationSettings.AppSettings["DBPwd"].ToString();

        public String SqlStrCon;
        SqlConnection _Connection;

        public SqlConnection open()
        {
            SqlStrCon = "Server =" + Server + ";";
            SqlStrCon += "Database =" + SqlDatabaseName + ";";
            SqlStrCon += "User ID =" + SqlUser + ";";
            SqlStrCon += "Password =" + SqlPassword + ";";

            _Connection = new SqlConnection(SqlStrCon);
            if (_Connection.State == ConnectionState.Closed)
                _Connection.Open();
            else
                _Connection.Close();
            return _Connection;
        }
    }
}
