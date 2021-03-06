﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OnlineExamSystem.Models;
using OnlineExamSystem.ViewModels;

namespace OnlineExamSystem.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }

        public DbSet<OnlineExamSystem.Models.Admin> Admin { get; set; }

        public DbSet<OnlineExamSystem.Models.Exam> Exam { get; set; }

        public DbSet<OnlineExamSystem.Models.Question> Question { get; set; }

        public DbSet<OnlineExamSystem.Models.Student> Student { get; set; }

        public DbSet<OnlineExamSystem.Models.StudentResult> StudentResult{ get; set; }

        public DbSet<OnlineExamSystem.ViewModels.ExamQuestion> ExamQuestion { get; set; }
    }
}
