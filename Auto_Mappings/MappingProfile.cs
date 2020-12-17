using AutoMapper;
using employee_management_system.Data;
using employee_management_system.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace employee_management_system.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<LeaveType, LeaveTypeViewModel>().ReverseMap();

            CreateMap<LeaveAllocation, LeaveAllocationViewModel>().ReverseMap();

            CreateMap<LeaveRequest, LeaveRequestViewModel>().ReverseMap();

            CreateMap<Employee, EmployeeViewModel>().ReverseMap();

        }
    }
}
