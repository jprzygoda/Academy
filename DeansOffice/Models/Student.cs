using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeansOffice.Models
{
    public class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public int Phone { get; set; }
        public string PassportNumber { get; set; }
        public string Citizenship { get; set; }
        public string CityOfBirth { get; set; }
        public int YearOfBirth { get; set; }
        public String Faculty { get; set; }         
        public int IndexNumber { get; set; }
        public int YearOfRegistration { get; set; }
        public string Photo { get; set; }

    }
}
