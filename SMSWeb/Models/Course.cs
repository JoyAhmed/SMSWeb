using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SMSWeb.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string CourseCode { get; set; }
        public string Title { get; set; }
        public CourseType TypeOfCourse { get; set; }
        public int BranchId { get; set; }
        public int YearId { get; set; }

        public virtual List<StudentCourse> StudentCourse { get; set; }
        public virtual List<TeacherCourse> TeacherCourse { get; set; }
        public virtual Branch Branch { get; set; }
        public Year Year { get; set; }
    }

    public enum CourseType
    {
        Theory,
        Practical,
        Both
    }
}
