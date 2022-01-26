using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission4_MasonPerry.Models
{
    public class Movies
    {
        [Key]
        [Required]
        public int MovieId { get; set; }
        public string Category { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public string Director { get; set; }
        public string Rating { get; set; }
        public bool Edited { get; set; }
        public string Lent { get; set; }
        public string Notes { get; set; }
    }
}

Category Title	Year	Director	Rating	Edited	Lent To:	Notes
