using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using AttendanceManagementSys.Models;

namespace AttendanceManagementSys.Controllers
{
    public class TimeSlotController : Controller
    {
        // GET: TimeSlot
        public ActionResult Index()
        {
            System.Data.DataTable dt = new Time_Slot().GetAllTImeSlot();

            return View(dt);
        }
    }
}