using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.DAL.Entities
{
   
   public class EmployeeN
    {
        [Key]
        public int EmployeeID { get; set; }


        [Required(ErrorMessage ="you Must Enter the Fiirst Name")]
        [MaxLength(50,ErrorMessage ="First Name Must be 50")]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(50,ErrorMessage ="LastName Must be 50")]
        public string LastName { get; set; }
        [Required]
        [EmailAddress(ErrorMessage ="Please Enter Your Email")]
        public string EmailAddress { get; set; }
        [Required]
        [Compare("EmailAddress",ErrorMessage ="Email Address is not match")]
        public string ConfirmEmailAddress { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare("Password" ,ErrorMessage ="password is not matched")]
        [Display(Name ="Confirm Password")]
        public string ConfirmPassword { get; set; }

        public string Country { get; set; }

        public string City { get; set; }
        [DataType(DataType.Url)]
        public string URL { get; set; }

        public string Gender { get; set; }
        [DataType(DataType.Currency)]
        public double Salary { get; set; }
        [Display(Name = "IS active")]
        public bool isactive { get; set; }
        [Display(Name ="IS ALive")]
        public bool isalive { get; set; }
        [DataType(DataType.DateTime)]
        [Required]
        [Display(Name ="Hire Date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime HireDate { get; set; }

    }
}
