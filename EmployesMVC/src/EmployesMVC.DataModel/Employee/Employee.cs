using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployesMVC.DataModel.Employee
{
    public class Employee
    {
        public int Id { get; set; }
        public string Employee_Name { get; set; }
        public decimal Employee_Salary { get; set; }
        public int Employee_Age { get; set; }
        public string Profile_Image { get; set; }

       // "id":1,"employee_name":"Tiger Nixon","employee_salary":320800,"employee_age":61,"profile_image":""
    }
}
