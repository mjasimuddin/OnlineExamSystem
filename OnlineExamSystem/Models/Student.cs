using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineExamSystem.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        [Required(ErrorMessage = "Please Enter Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please Enter Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please Enter Address")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Please Enter Name")]
        [Display(Name = "Phone Number")]
        public string PhoneNo { get; set; }
        [Required(ErrorMessage = "Please Enter Nationality")]
        public string Nationality { get; set; }
        public byte[] Photo { get; set; }

        public List<StudentResult> StudentResult { get; set; }
    }
}
