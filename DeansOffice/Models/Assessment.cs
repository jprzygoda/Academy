using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeansOffice.Models
{
    class Assessment
    {
        public String AssessmentName { get; set; }
        public Student Student { get; set; }
        public Teacher Teacher { get; set; }
        public string Subject { get; set; }

    }
}
