using AutoMapper;
using EmployesMVC.Models;
using EmployesMVC.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployesMVC.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly IEmployeeService _employeeService;
        private readonly IMapper _mapper;
        // Imena proba
        public EmployeesController(IEmployeeService employeeService, IMapper mapper)
        {
            _employeeService = employeeService;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            var employessDM = await _employeeService.GetEmployees();
            if(employessDM.Status !="sucsess" || employessDM.Data == null)
            {
                return NotFound();
            }
            IEnumerable<EmployeeViewModel> employees = _mapper.Map<IEnumerable<EmployeeViewModel>>(employessDM.Data);

            return View(employees);
        }
    }
}
