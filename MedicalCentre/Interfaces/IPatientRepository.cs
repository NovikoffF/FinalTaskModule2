using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MedicalCentre.Models;

namespace MedicalCentre.Interfaces
{
    public interface IPatientRepository
    {
        IEnumerable<Patient> GetPatients();
        IEnumerable<Patient> GetRecentPatients();
        Patient GetPatient(int id);
        void Add(Patient patient);
        void Remove(Patient patient);
    }
}