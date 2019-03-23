using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SMSWeb.Models;
using SMSWeb.ViewModels;

namespace SMSWeb.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Branch> Branch { get; set; }
        public DbSet<Year> Year { get; set; }
        public DbSet<Course> Course { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<StudentCourse>().HasKey(t => new { t.ApplicationUserId, t.CourseId });
            builder.Entity<TeacherCourse>().HasKey(t => new { t.ApplicationuserId, t.CourseId });
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }

        public DbSet<SMSWeb.ViewModels.StudentViewModel> StudentViewModel { get; set; }

        //public DbSet<SMSWeb.ViewModels.TeacherViewMovel> TeacherViewMovel { get; set; }
    }
}
