using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AttendanceManagementSys.Models;

namespace AttendanceManagementSys.Controllers
{
    public class CoursesController : Controller
    {
        // GET: Courses
        public ActionResult Index()
        {
            //System.Data.DataTable dt = new System.Data.DataTable();
            //CoursesClass course = new CoursesClass();

            System.Data.DataTable dt = new CoursesClass().GetAllCourses();


            return View(dt);
        }
    }
}