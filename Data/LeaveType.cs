﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace employee_management_system.Data
{
    public class LeaveType
    {
        [Key]
        public int Id { get; set; }

        public String Name { get; set; }

        public DateTime DateCreated { get; set; }
    }
}
