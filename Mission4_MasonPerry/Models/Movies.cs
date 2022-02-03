﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Mission5.Models;

namespace Mission4_MasonPerry.Models
{
    public class Movies
    {
        [Key]
        [Required]
        public int MovieId { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public int Year { get; set; }
        [Required]
        public string Director { get; set; }
        [Required]
        public string Rating { get; set; }
        public bool Edited { get; set; }
        public string Lent { get; set; }
        [MaxLength(25)]
        public string Notes { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
