using DeansOffice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeansOffice.DAL
{
    public interface IDeansOfficeDb
    {
        IEnumerable<Student> GetStudents(String SqlCommand);
        void AddStudent(string name, string surname, string email, int phone, string passportNumber, string citizenship, string cityOfBirth, int yearOfBirth, string faculty, int indexNumber, int yearOfRegistration, string photo);
        void RemoveStudent(String index);
    }
}
