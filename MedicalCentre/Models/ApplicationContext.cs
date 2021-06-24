using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MedicalCentre.Models
{
    public class ApplicationContext: DbContext
    {
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Attendance> Attendances { get; set; }
        public DbSet<Specialization> Specializations { get; set; }
        public DbSet<City> Cities { get; set; }

        public static ApplicationContext Create()
        {
            return new ApplicationContext();
        }
        //InProgress
    }
}