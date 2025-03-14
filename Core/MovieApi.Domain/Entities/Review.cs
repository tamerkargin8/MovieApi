﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Domain.Entities
{
    public  class Review
    {
        public int ReviewId { get; set; }
        public string ReviewComment { get; set; }
        public int ReviewRating { get; set; }
        public DateTime ReviewDate { get; set; }
        public bool ReviewStatus { get; set; }
    }
}
