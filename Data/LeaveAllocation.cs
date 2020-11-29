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
        public Employee Employee { get; set; }
        [ForeignKey("EmployeeId")]
        public String EmployeeId { get; set; }

        //leavetype record
        public LeaveType LeaveType { get; set; }
        [ForeignKey("LeaveTypeId")]
        public int LeaveTypeId { get; set; }
        
    }
}
