using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission06_ckearl2.Models
{
    public class Movie
    {
        [Key]
        [Required]
        public int MovieID { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Rating { get; set; }
        public bool Edited { get;  set; } 
        public string LentTo { get; set; }
        public string Notes { get; set; }
    }
}
