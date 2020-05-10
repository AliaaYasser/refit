using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication17.Controllers
{
    public class AttendanceController : Controller
    {
        // GET: Attendance
        public ActionResult Index()
        {
            return View();
        }

        // GET: Attendance/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Attendance/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Attendance/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Attendance/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Attendance/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Attendance/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Attendance/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult addAttendance()
        {
            return Redirect("showAllAttendance");
        }


        public ActionResult showAllAttendance()
        {
            return View();
        }

        public ActionResult showFollowAttendance()
        {
            return View();
        }


        public ActionResult showAllAppointment()
        {
            return View();
        }

        public ActionResult addMediaToPlayer()
        {
            return View();
        }


        public ActionResult addAppointment()
        {
            return View();
        }
        public ActionResult showAllMedia()
        {
            return View();
        }
        public ActionResult addFinances()
        {
            return View();
        }
        public ActionResult showAllFinance()
        {
            return View();
        }

        public ActionResult showLoadsChart()
        {
            return View();
        }

        public ActionResult showFitnessChart()
        {
            return View();
        }
        public ActionResult showLowerMachineChart()
        {
            return View();
        }

        public ActionResult showMeasurementChart()
        {
            return View();
        }
    }

}
