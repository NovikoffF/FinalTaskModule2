using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MedicalCentre;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using MedicalCentre.Interfaces;

namespace MedicalCentre.Controllers
{
    [Authorize]
    public class DoctorController:Controller
    {
        private readonly IUnitOfWork uOfWork;

        public DoctorController(IUnitOfWork unitOfWork)
        {
            uOfWork = unitOfWork;
        }

        public ActionResult Index()
        {
            
        }

        public ActionResult Details(int id)
        {
            
                return View();
           
        }
    }
}