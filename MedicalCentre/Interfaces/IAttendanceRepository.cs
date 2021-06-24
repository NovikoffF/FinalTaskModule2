using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MedicalCentre.Models;

namespace MedicalCentre.Interfaces
{
    public interface IAttendanceRepository
    {
        IEnumerable<Attendance> GetAttendances();
        IEnumerable<Attendance> GetAttendances(int id);
        IEnumerable<Attendance> GetPatientAttandences(string searchTerm = null);
        int CountAttendances(int id);
        void Add(Attendance attendance);
    }
}