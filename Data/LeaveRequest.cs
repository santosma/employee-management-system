using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace employee_management_system.Data
{
    public class LeaveRequest
    {
        [Key]
        public int Id { get; set; }

        //employee requesting off
        [ForeignKey("RequestingEmployeeId")]
        public Employee RequestingEmployee { get; set; }
        public string RequestingEmployeeId { get; set; }

        //when the leave is applicable, the time frame
        public DateTime StartLeave { get; set; }
        public DateTime EndLeave { get; set; }

        [ForeignKey("LeaveTypeId")]
        public LeaveType LeaveType { get; set; }
        public int LeaveTypeId { get; set; }

        //requesting employees submission and approval dates
        public DateTime DateSubmitted { get; set; }
        public DateTime DateApproved { get; set; }

        //this boolean acts as a third state, a null state once changed it will update dateapproved
        public bool? Approved { get; set; }

        //an authorized employee of the company
        [ForeignKey("ApprovedById")]
        public Employee ApprovedBy { get; set; }
        public string ApprovedById { get; set; }

    }
}
