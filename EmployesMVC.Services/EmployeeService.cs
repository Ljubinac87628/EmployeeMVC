using EmployesMVC.DataModel;
using EmployesMVC.DataModel.Employee;
using EmployesMVC.Services.Interfaces;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace EmployesMVC.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly HttpClient _employeeRestService;
        private readonly IConfiguration _configuration;

        public EmployeeService( IConfiguration configuration)
        {
            _configuration = configuration;
            _employeeRestService = new HttpClient();

            _employeeRestService.BaseAddress = new Uri(_configuration.GetSection("ExternalServices").GetSection("EmployeeAPI").Value);

        }
        public async Task<CommandResponse<IEnumerable<Employee>>> GetEmployees()
        {
            var resault = new CommandResponse<IEnumerable<Employee>>();
            try
            {
                var responce = await _employeeRestService.GetAsync("employees");
                if (responce.IsSuccessStatusCode) 
                {
                    var content = await responce.Content.ReadAsStringAsync();
                    JsonConvert.DeserializeObject<CommandResponse<IEnumerable<Employee>>>(content);
                }
            }
            catch( Exception ex)
            {
                resault.Status = "Exception";
                resault.Message = ex.Message;
            }
            return resault;
        }
    }
}
