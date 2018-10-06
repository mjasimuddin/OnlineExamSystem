using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineExamSystem.Data;
using OnlineExamSystem.Models;
using OnlineExamSystem.ViewModels;

namespace OnlineExamSystem.Controllers
{
    public class ExamQuestionsController : Controller
    {
        private readonly ApplicationDbContext db;

        public ExamQuestionsController(ApplicationDbContext context)
        {
            db = context;
        }


        public async Task<IActionResult> CSharp(int? page)
        {
            IQueryable<Question> question = db.Question;
            if (page == null) page = 1;

            var query = (from q in db.Question
                         where q.ExamID == 1
                         select new Question
                         {
                             Title = q.Title,
                             Option1 = q.Option1,
                             Option2 = q.Option2,
                             Option3 = q.Option3,
                             Option4 = q.Option4,
                             CorrectAnswer= q.CorrectAnswer,
                             QuestionId = q.QuestionId
                         }).ToList();
            ViewBag.result = query;

            int pageSize = 3;
            return View(await PaginatedList<Question>.CreateAsync(question.AsNoTracking(), (int)page, pageSize));
        }


        public async Task<IActionResult> SQLSERVER(int? page)
        {
            IQueryable<Question> question = db.Question;
            if (page == null) page = 1; ;

            var query = (from q in db.Question
                         where q.ExamID == 2
                         select new Question
                         {
                             Title = q.Title,
                             Option1 = q.Option1,
                             Option2 = q.Option2,
                             Option3 = q.Option3,
                             Option4 = q.Option4,
                             CorrectAnswer = q.CorrectAnswer,
                             QuestionId = q.QuestionId
                         }).ToList();

            ViewBag.result = query;

            int pageSize = 3;
            return View(await PaginatedList<Question>.CreateAsync(question.AsNoTracking(), (int)page, pageSize));
        }

        public async Task<IActionResult> Index()
        {
            //IQueryable<Exam> exam = db.Exam;
            //if (page == null) page = 1;
            //int pageSize = 3;
            //return View(await PaginatedList<Exam>.CreateAsync(exam.AsNoTracking(), (int)page, pageSize));

            return View();
        }

        public JsonResult SaveResult(List<ExamResult> result)
        {

            return Json("Save");
        }
    }
}