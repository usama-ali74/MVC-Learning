using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace AttendanceManagementSys.Models
{
    public class CoursesClass
    {
        public DataTable GetAllCourses()
        {
            //SqlConnection sc = new SqlConnection("");
            SqlCommand sqlCommand = new SqlCommand("Select * from Courses", Connection.GetConnection());
            sqlCommand.CommandType = CommandType.Text;
            SqlDataAdapter sda = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
    }
}