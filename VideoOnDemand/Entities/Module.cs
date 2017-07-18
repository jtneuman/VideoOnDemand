using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using VideoOnDemand.Models;

namespace VideoOnDemand.Entities
{
    public class Module
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(80), Required]
        public string Title { get; set; }

        // Nav props

        public int CourseId { get; set; }
        public Course Course { get; set; }
        public List<Video> Videos { get; set; }
        public List<Download> Downloads { get; set; }

    }
}
