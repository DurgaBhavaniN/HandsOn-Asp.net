using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
namespace ModelValidations.Models
{
    public class Login
    {
        [Required(ErrorMessage ="UserName is Required")]
        [DisplayName("UserName")]
        public string Uname { get; set; }
        [Required(ErrorMessage ="Password is Required")]
        [DisplayName("Password")]
        public string Pwd { get; set; }
    }
}
