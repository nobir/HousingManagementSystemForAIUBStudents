using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingManagementSystemForAIUBStudents.Models
{
    class House
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Number { get; set; }
        public int Sector { get; set; }
        public double Prize { get; set; }
        public bool Status { get; set; }
    }
}
