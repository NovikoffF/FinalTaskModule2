using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace MedicalCentre.Models
{
    public class User
    {
        public int Id { get; set; }
        /*public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }*/
        public string Login { get; set; }
        public string Password { get; set; }
        // In progress
        
    }
}