using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission06_ckearl2.Models
{
    public class MovieContext : DbContext
    {
        // Constructor
        public MovieContext (DbContextOptions<MovieContext> options) : base(options)
        {
            // Leave blank for now
        }

        public DbSet<Movie> movies { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Movie>().HasData(
                
                new Movie
                {
                    MovieID = 1,
                    Title = "Ferris Bueller's Day Off",
                    Rating = "PG-13",
                    Edited = false,
                    LentTo = "-",
                    Notes = "This movie is based in Chicago",
                },

                new Movie
                {
                    MovieID = 2,
                    Title = "School of Rock",
                    Rating = "PG-13",
                    Edited = false,
                    LentTo = "-",
                    Notes = "Jack Black is my hero",
                },

                new Movie
                {
                    MovieID = 3,
                    Title = "The Sandlot",
                    Rating = "PG",
                    Edited = false,
                    LentTo = "Scotty Smalls",
                    Notes = "A cult classic",
                },

                new Movie
                {
                    MovieID = 4,
                    Title = "Whiplash",
                    Rating = "R",
                    Edited = true,
                    LentTo = "J.K. Simmons",
                    Notes = "GOAT movie",
                },
                
                new Movie
                {
                    MovieID = 5,
                    Title = "Good Will Hunting",
                    Rating = "R",
                    Edited = true,
                    LentTo = "Matt Damon",
                    Notes = "The most stacked cast of all time",
                }
            );
        }
    }
}
