using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;


namespace ModelValidations.Models
{
    public class Employee
    {
        [Required(ErrorMessage="Pls Enter ID")]
        [DisplayName("Employee ID")]
        public int ID { get; set; }
        [Required(ErrorMessage ="Plz enter name")]
        [StringLength(maximumLength:20,MinimumLength =4,ErrorMessage ="Name should between 4 to 20 characters" )]
            public string Name { get; set; }
        [EmailAddress(ErrorMessage ="Invalid Email ID")]
        public string Email { get; set; }
        [RegularExpression(@"[6-9]\d{9}",ErrorMessage ="Invalid Mobile no")]
        public string Mobile { get; set; }
        [Required(ErrorMessage ="Username is Required")]
        public string Uname { get; set; }
        [Required(ErrorMessage ="Password is Required")]
        [RegularExpression("[a-z0-9]{6,8}")]
        public string Pwd { get; set; }
        [Compare("Pwd",ErrorMessage ="Password Mismatch")]
        public string Cpwd { get; set; }

    }
}
