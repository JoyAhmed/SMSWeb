using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SMSWeb.Models
{
    public class TeacherCourse
    {
        public int Id { get; set; }
        public string ApplicationuserId { get; set; }
        public int CourseId { get; set; }

        public virtual ApplicationUser Teacher { get; set; }
        public virtual Course Course { get; set; }
    }
}
