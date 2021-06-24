using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MedicalCentre.Models;

namespace MedicalCentre.Interfaces
{
    public interface ISpecializationRepository
    {
        IEnumerable<Specialization> GetSpecializations();
    }
}