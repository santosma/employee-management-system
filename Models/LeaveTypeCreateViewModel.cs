using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace employee_management_system.Models
{
    public class LeaveTypeCreateViewModel
    {
        [Required]
        public String Name { get; set; }
    }
}
