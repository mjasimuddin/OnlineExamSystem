using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OnlineExamSystem.Data;

namespace OnlineExamSystem.Controllers
{
    public class StudentResultsController : Controller
    {
        private readonly ApplicationDbContext db;

        public StudentResultsController(ApplicationDbContext context)
        {
            db = context;
        }


        public IActionResult CSharp()
        {
            var query = (from q in db.Question
                         where q.ExamID == 1
                         select new
                         {
                             Title = q.Title,
                             Option1 = q.Option1,
                             Option2 = q.Option2,
                             Option3 = q.Option3,
                             Option4 = q.Option4
                         }).ToList();
            
            return View(query);
    }
}
}