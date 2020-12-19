using employee_management_system.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace employee_management_system.Contracts
{
    public interface ILeaveAllocationRepository : IRepositoryBase<LeaveAllocation>
    {
       public  bool validate (string employeeId, int leaveTypeId);
    }
}
