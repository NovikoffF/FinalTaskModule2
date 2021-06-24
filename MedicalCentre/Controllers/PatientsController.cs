using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MedicalCentre.Models;
using MedicalCentre.Interfaces;

namespace MedicalCentre.Controllers
{
    [Authorize (Roles = RoleName.DoctorRole + "," + RoleName.AdminRole)]
    public class PatientsController : Controller
    {
        private readonly IUnitOfWork uOfWork;
        public PatientsController(IUnitOfWork unitOfWork)
        {
            uOfWork = unitOfWork;
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Details(int id)
        {
            var viewModel = new PatientDetailViewModel()
            {
                Patient = uOfWork.Patients.GetPatient(id),
                Appointment = uOfWork.Appointments.GetAppointmentWithPatient(id),
                Attendance = uOfWork.Attendances.GetAttendances(id),
     

            };
            return View(viewModel);
        }

        [Authorize]
        public ActionResult Create()
        {
            var viewModel = new PatientForm
            {
                Cities = uOfWork.Cities.GetCities(),
                Heading = "New Patient"
            };
            return View();
        }
        //In Progress
    }
}