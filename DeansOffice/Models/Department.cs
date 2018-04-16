using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeansOffice.Models
{
    class Department
    {
        public String DepartmentName { get; set; }
        public int DepartmentNumber { get; set; }
        public Teacher DepartmentHead { get; set; }
    }
}
