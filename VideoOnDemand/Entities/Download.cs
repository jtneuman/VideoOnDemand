﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using VideoOnDemand.Models;

namespace VideoOnDemand.Entities
{
    public class Download
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(80), Required]
        public string Title { get; set; }

        [MaxLength(1024)]
        public string Url { get; set; }

        public int ModuleId { get; set; }
        // Side step from 3rd normal form for
        // easier access to a video's course
        public int CourseId { get; set; }

    }
}
