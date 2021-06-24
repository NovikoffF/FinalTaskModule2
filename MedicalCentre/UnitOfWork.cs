using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MedicalCentre.Models;
using MedicalCentre.Interfaces;

namespace MedicalCentre
{
    public class UnitOfWork
    {
        private readonly ApplicationContext dbcontext;
        public IPatientRepository Patients { get; private set; }
        public IAttendanceRepository Attendances { get; private set; }
        public ICityRepository Cities { get; private set; }
        public IDoctorRepository Doctors { get; private set; }
        public ISpecializationRepository Specializations { get; private set; }
       
        public UnitOfWork (ApplicationContext db)
        {
            dbcontext = db;
            //InProgress
        }
    }
}