using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeansOffice.Models
{
    class Subject
    {
        public int SubjectID { get; set; }
        public string SubjectName { get; set; }
        public Teacher Teacher { get; set; }
        public List<Student> Students { get; set; }
    }
}
