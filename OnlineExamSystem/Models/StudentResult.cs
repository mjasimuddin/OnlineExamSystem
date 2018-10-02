using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineExamSystem.Models
{
    public class StudentResult
    {
        public int StudentResultId { get; set; }
        public int ExamID { get; set; }
        public int StudentId { get; set; }
        public int TotalQuestion { get; set; }
        [StringLength(1, ErrorMessage = "MaxLength 1")]
        [Display(Name ="Selected Ans Q1")]
        public string AnsQ1 { get; set; }
        [StringLength(1, ErrorMessage = "MaxLength 1")]
        [Display(Name = "Selected Ans Q2")]
        public string AnsQ2 { get; set; }
        [StringLength(1, ErrorMessage = "MaxLength 1")]
        [Display(Name = "Selected Ans Q3")]
        public string AnsQ3 { get; set; }
        [StringLength(1, ErrorMessage = "MaxLength 1")]
        [Display(Name = "Selected Ans Q4")]
        public string AnsQ4 { get; set; }
        [StringLength(1, ErrorMessage = "MaxLength 1")]
        [Display(Name = "Selected Ans Q5")]
        public string AnsQ5 { get; set; }
        [StringLength(1, ErrorMessage = "MaxLength 1")]
        [Display(Name = "Selected Ans Q6")]
        public string AnsQ6 { get; set; }
        [StringLength(1, ErrorMessage = "MaxLength 1")]
        [Display(Name = "Selected Ans Q7")]
        public string AnsQ7 { get; set; }
        [StringLength(1, ErrorMessage = "MaxLength 1")]
        [Display(Name = "Selected Ans Q8")]
        public string AnsQ8 { get; set; }
        [StringLength(1, ErrorMessage = "MaxLength 1")]
        [Display(Name = "Selected Ans Q9")]
        public string AnsQ9 { get; set; }
        [StringLength(1, ErrorMessage = "MaxLength 1")]
        [Display(Name = "Selected Ans Q10")]
        public string AnsQ10 { get; set; }
        public int Attempted { get; set; }
        public int CountCorrectAns { get; set; }
        [Required]
        public DateTime DateTimes { get; set; }
        [Required]
        [DataType(DataType.Time)]
        public DateTime TimeCount { get; set; }
        public double Score { get; set; }

        public Exam Exam { get; set; }
        public Student Student { get; set; }
    }
}
