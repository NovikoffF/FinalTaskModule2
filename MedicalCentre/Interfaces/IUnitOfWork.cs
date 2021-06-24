using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MedicalCentre.Interfaces;

namespace MedicalCentre.Interfaces
{
    public interface IUnitOfWork
    {
       IPatientRepository Patients { get;  }
        IAppointmentRepository Appointments { get; }
        IAttendanceRepository Attendances { get;  }
        ICityRepository Cities { get; set; }
        IDoctorRepository Doctors { get;  }
        ISpecializationRepository Specialization { get; }

        void Complete();
    }
}