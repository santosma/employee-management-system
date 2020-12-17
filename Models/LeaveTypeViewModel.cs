using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace employee_management_system.Models
{
    public class LeaveTypeViewModel
    {
        private const int maxNumOfDays = 30;
        private const int minNumOfDays = 1;

        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [Range(minNumOfDays, maxNumOfDays, ErrorMessage="Valid values 1-30")]
        [Display(Name = "Default days off")]
        public int DefaultDaysOff { get; set; }
        [Display(Name = "Date Created")]
        public DateTime? DateCreated { get; set; }
    }
}
