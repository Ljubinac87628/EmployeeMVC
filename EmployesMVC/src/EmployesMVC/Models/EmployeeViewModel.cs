using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployesMVC.Models
{
    public class EmployeeViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public int Age { get; set; }
        public int YearOfBirth { get; set; }
        public string ProfileImage { get; set; }
    }
}
