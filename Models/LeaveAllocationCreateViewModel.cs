using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace employee_management_system.Models
{
    public class LeaveAllocationCreateViewModel : Controller
    {
        public int NumberUpdated { get; set; }
        public List<LeaveTypeViewModel> LeaveTypeList { get; set; }

    }
}
