using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace SMSWeb.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public DateTime BirthDate { get; set; }
        public string Address { get; set; }

        public string EnrollemntNo { get; set; }

        public string FatherName { get; set; }

        public Gender Gender { get; set; }

        public virtual List<StudentCourse> StudentCourse { get; set; }

        public virtual List<TeacherCourse> TeacherCourse { get; set; }
    }

    public enum Gender
    {
        Male,
        Female,
        Other
    }
}
