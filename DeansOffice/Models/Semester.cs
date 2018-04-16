using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeansOffice.Models
{
    class Semester
    {
        public int SemesterNumber { get; set; }
        public List<Student> Students { get; set; }
    }
}
