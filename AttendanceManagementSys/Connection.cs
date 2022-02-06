using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace AttendanceManagementSys
{
    public class Connection
    {
        public static SqlConnection SqlConnection;
        public static SqlConnection GetConnection()
        {
            if (SqlConnection == null )
                {
                SqlConnection = new SqlConnection();
                SqlConnection.ConnectionString = @"Data Source=DESKTOP-BE3FCKD;Initial Catalog=wdd;Integrated Security=True";
                SqlConnection.Open();
            }
            return SqlConnection;
        }
    }
}