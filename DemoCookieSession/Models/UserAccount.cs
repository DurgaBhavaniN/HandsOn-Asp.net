using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace DemoCookieSession.Models
{
    public class UserAccount
    {
        [Key]
        public string UserName { get; set; }
        [DataType("Password")]
        public string Password { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public bool Status { get; set; }
    }
}
