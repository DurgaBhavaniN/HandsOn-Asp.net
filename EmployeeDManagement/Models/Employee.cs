using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EmployeeDManagement.Models
{
    public class Employee
    {
      
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        public department Dept { get; set; }


    }
    public enum department
    {
        IT,Accounts,Insurance,HealthCare
    }
}
