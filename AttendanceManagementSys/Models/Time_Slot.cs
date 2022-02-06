using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace AttendanceManagementSys.Models
{
    public class Time_Slot
    {
        public DataTable GetAllTImeSlot()
        {
            SqlCommand sqlCommand = new SqlCommand("Select * from Time_Slot", Connection.GetConnection());
            sqlCommand.CommandType = CommandType.Text;
            SqlDataAdapter sda = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
    }
}