using System;
using System.Collections.Generic;
using System.EnterpriseServices;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace SampleMvcApp.Models
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeAddress { get; set; }
        public int EmployeeSalary { get; set; }

        public override string ToString()
        {
            return $"<p> The Name:{EmployeeName}</p><p>The Address:{EmployeeAddress}</p><p>Employee Salary:{EmployeeSalary:C}";
        }


    }
}