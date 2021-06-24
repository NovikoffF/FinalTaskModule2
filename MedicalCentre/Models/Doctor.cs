using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections.ObjectModel;

namespace MedicalCentre.Models
{
    public class Doctor
    {
        public int DoctorId { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public Specialization Specialization { get; set; }
        public int PatientId { get; set; }
        public string SpecializationId { get; set; }
        public ICollection<Appointment> Appointments { get; set; }

        public Doctor()
        {
            Appointments = new Collection<Appointment>();
        }
    }
}