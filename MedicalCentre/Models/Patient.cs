using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections.ObjectModel;

namespace MedicalCentre.Models
{
    public class Patient
    {
        public int PatientId { get; set; }
        public string Name { get; set; }
        public string Surename { get; set; }
        public string SecondName { get; set; }
        public Gender Sex { get; set; }
        public DateTime BirthDate { get; set; }
        public string Phone { get; set; }
        public DateTime DateTime { get; set; }
        public string Address { get; set; }
        public string CityId { get; set; }
        public City Cities { get; set; }
        public string Height { get; set; }
        public string Weight { get; set; }
        public string BloodType { get; set; }

        public ICollection<Appointment> Appointments { get; set; }
        public ICollection<Attendance> Attendances { get; set; }

        public int Age
        {
            get
            {
                var now = DateTime.Today;
                var age = now.Year - BirthDate.Year;
                if (BirthDate > now.AddYears(-age)) age--;
                return age;
            }
        }

        public Patient()
        {
            Appointments = new Collection<Appointment>();
            Attendances = new Collection<Attendance>();
        }

    }
}