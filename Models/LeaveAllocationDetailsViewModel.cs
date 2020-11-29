using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace employee_management_system.Models
{
    public class LeaveAllocationDetailsViewModel
    {
        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
        public int NumOfDays { get; set; }

        public EmployeeViewModel Employee { get; set; }
        public String EmployeeId { get; set; }

        public LeaveTypeDetailsViewModel LeaveType { get; set; }
        public int LeaveTypeId { get; set; }
    }
}
