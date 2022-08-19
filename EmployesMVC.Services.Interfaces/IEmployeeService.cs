using EmployesMVC.DataModel;
using EmployesMVC.DataModel.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployesMVC.Services.Interfaces
{
    public interface IEmployeeService
    {
       Task< CommandResponse<IEnumerable<Employee>>> GetEmployees();
    }
}
