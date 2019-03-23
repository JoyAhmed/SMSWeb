using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SMSWeb.Models
{
    public class StudentCourse
    {
        public int Id { get; set; }
        public string Note { get; set; }
        public string ApplicationUserId { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public int CourseId { get; set; }

        public virtual ApplicationUser Student { get; set; }
        public virtual Course Course { get; set; }
    }
}
