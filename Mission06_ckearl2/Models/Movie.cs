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
        [Required(ErrorMessage = "Movie Title is a required field")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Rating is a required field")]
        public string Rating { get; set; }
        public bool Edited { get;  set; } 
        public string LentTo { get; set; }
        [StringLength(25, MinimumLength = 1, ErrorMessage = "Maximum of 25 characters")]
        public string Notes { get; set; }
    }
}
