using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MedicalCentre.Models;

namespace MedicalCentre.Interfaces
{
    public interface IDoctorRepository
    {
        IEnumerable<Doctor> GetDoctors();
        IEnumerable<Doctor> GetAvailableDoctors();
        Doctor GetDoctor(int id);
        void Add(Doctor doctor);
    }
}