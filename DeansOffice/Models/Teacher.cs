using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeansOffice.Models
{
    class Teacher
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public Department Department { get; set; }
        
    }
}
