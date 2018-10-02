using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineExamSystem.Models
{
    public class Exam
    {
        public int ExamID { get; set; }
        [Required(ErrorMessage = "Enter Subject Name")]
        public string Subject { get; set; }
        [Required(ErrorMessage = "Enter Description")]
        public string Description { get; set; }

        public List<Question> Question { get; set; }
        public List<StudentResult> StudentResult { get; set; }
    }
}
