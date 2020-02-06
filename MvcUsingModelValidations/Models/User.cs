using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
    

namespace MvcUsingModelValidations.Models
{
    public class User
    {
        [Required(ErrorMessage ="Plz Enter Name")]
        [StringLength(maximumLength:20, MinimumLength= 4, ErrorMessage ="Name should between 4 to 20 characters")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Incorrect Email Id")]
        public string Email { get; set; }
        [Required(ErrorMessage="Enter DOB")]
      
        public  DateTime DOB{ get; set; }
        [RegularExpression(@"[6-9]\d{9}",ErrorMessage="Invalid mobile num")]
        public string Phnno { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Select Country")]
        public string Country { get; set; }
        [Required(ErrorMessage="Plz enter userName")]
        public string UName { get; set; }
        [Required(ErrorMessage = "Password is Required")]
        [RegularExpression("[a-z0-9]{6,8}")]
        public string Pwd { get; set; }
    }
}
