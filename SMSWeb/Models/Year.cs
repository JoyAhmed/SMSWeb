using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SMSWeb.Models
{
    public class Year
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual List<Course> Course { get; set; }
    }
}
