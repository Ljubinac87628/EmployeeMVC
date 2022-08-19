using AutoMapper;
using EmployesMVC.DataModel.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployesMVC.Models.Maper
{
    public class Model2ViewModel : Profile
    {
        public Model2ViewModel()
        {
            this.CreateMap<Employee, EmployeeViewModel>()
            .ForMember(e => e.Name, evm => evm.MapFrom(c => c.Employee_Name))
            .ForMember(e => e.ProfileImage, evm => evm.MapFrom(c => c.Profile_Image))
            .ForMember(e => e.Salary, evm => evm.MapFrom(c => c.Employee_Salary))
            .ForMember(e => e.Age, evm => evm.MapFrom(c => c.Employee_Age));



        }
    }
}
