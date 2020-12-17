using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace employee_management_system.Data
{
    public class LeaveAllocation
    {
        [Key]
        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
        public int NumOfDays { get; set; }

        //employees record
        [ForeignKey("EmployeeId")]
        public Employee Employee { get; set; }
        public String EmployeeId { get; set; }

        //leavetype record
        [ForeignKey("LeaveTypeId")]
        public LeaveType LeaveType { get; set; }
        public int LeaveTypeId { get; set; }

        public int YearPeriod { get; set; }

    }
}
