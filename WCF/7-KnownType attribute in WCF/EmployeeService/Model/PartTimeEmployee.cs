﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmployeeService.Model
{
    public class PartTimeEmployee : Employee
    {
        public int HourlyPay { get; set; }
        public int HoursWorked { get; set; }
    }
}
