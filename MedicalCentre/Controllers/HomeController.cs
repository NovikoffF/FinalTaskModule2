using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MedicalCentre.Models;
using Microsoft.AspNet.Identity;

namespace MedicalCentre.Controllers
{
    public class HomeController : Controller
    {
        //ApplicationContext db = new ApplicationContext();
        private readonly ApplicationContext db;
        public HomeController()
        {
            db = new ApplicationContext();
        }

        public ActionResult Index()
        {
            //IEnumerable<Patient> patients = db.Patients;
            //ViewBag.Patients = patients;

            return View();
        }

        public ActionResult TotalPatients()
        {
            var patients = db.Patients.ToList();
            return Json(patients.Count(), JsonRequestBehavior.AllowGet);
        }

        public ActionResult TottalAppointments()
        {
            var appointments = db.Appointments.ToList();
            return Json(appointments.Count(), JsonRequestBehavior.AllowGet);
        }

        public ActionResult TotalDoctors()
        {
            var doctors = db.Doctors.ToList();
            return Json(doctors.Count(), JsonRequestBehavior.AllowGet);
        }


        public ActionResult TotalUsers()
        {
            var users = db.Users.ToList();
            return Json(users.Count(), JsonRequestBehavior.AllowGet);
        }

        // Пациенты, которые приходят СЕГОДНЯ
        public ActionResult TodaysPatients()
        {
            DateTime today = DateTime.Now.Date;
            var patients = db.Patients.Where(p => p.DateTime >= today).ToList();
            return Json(patients.Count(), JsonRequestBehavior.AllowGet);
        }
        // Назначеные встречи сегодня
        public ActionResult TodayAppointments()
        {
            DateTime today = DateTime.Now.Date;
            var appointments = db.Appointments.Where(a => a.StartDateTime >= today).ToList();
            return Json(appointments.Count(), JsonRequestBehavior.AllowGet);
        }


    }
}