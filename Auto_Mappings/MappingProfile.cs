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
            CreateMap<LeaveType, LeaveTypeCreateViewModel>().ReverseMap();
            CreateMap<LeaveType, LeaveTypeDetailsViewModel>().ReverseMap();

            CreateMap<LeaveAllocation, LeaveAllocationCreateViewModel>().ReverseMap();
            CreateMap<LeaveAllocation, LeaveAllocationDetailsViewModel>().ReverseMap();

            CreateMap<LeaveRequest, LeaveRequestCreateViewModel>().ReverseMap();
            CreateMap<LeaveRequest, LeaveRequestDetailsViewModel>().ReverseMap();

            CreateMap<Employee, EmployeeViewModel>().ReverseMap();

        }
    }
}
