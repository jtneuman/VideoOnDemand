using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VideoOnDemand.Models;

namespace VideoOnDemand.Entities
{
    public class UserCourse
    {
        public string UserId { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }

    }
}
