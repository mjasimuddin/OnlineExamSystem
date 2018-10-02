using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineExamSystem.Models
{
    public class Question
    {
        public int QuestionId { get; set; }
        [Required(ErrorMessage = "Enter Title")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Enter Answer1")]
        public string Option1 { get; set; }
        [Required(ErrorMessage = "Enter Answer2")]
        public string Option2 { get; set; }
        [Required(ErrorMessage = "Enter Answer3")]
        public string Option3 { get; set; }
        [Required(ErrorMessage = "Enter Answer4")]
        public string Option4 { get; set; }
        [Required(ErrorMessage = "Enter Correct Answer")]
        [Display(Name = "Correct Answer")]
        public string CorrectAnswer { get; set; }
        [Required(ErrorMessage = "Enter Question Explanation")]
        public string Explanation { get; set; }
        [Required(ErrorMessage = "Enter Question Order")]
        [Display(Name = "Question Order")]
        public int QuestionOrder { get; set; }
        public int ExamID { get; set; }

        public Exam Exam { get; set; }
    }
}
