﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace employee_management_system.Models
{
    public class LeaveRequestViewModel
    {
        public int Id { get; set; }
        
        public EmployeeViewModel RequestingEmployee { get; set; }
        public string RequestingEmployeeId { get; set; }

        [Required]
        public DateTime StartLeave { get; set; }
        [Required]
        public DateTime EndLeave { get; set; }


        public LeaveTypeViewModel LeaveType { get; set; }
        public int LeaveTypeId { get; set; }
        public IEnumerable<SelectListItem> LeaveTypes { get; set; }

        public DateTime DateSubmitted { get; set; }
        public DateTime DateApproved { get; set; }

        public bool? Approved { get; set; }

        public EmployeeViewModel ApprovedBy { get; set; }
        public string ApprovedById { get; set; }

    }
}
