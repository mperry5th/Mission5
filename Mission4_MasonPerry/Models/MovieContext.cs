using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Mission4_MasonPerry.Models
{
    public class MovieContext : DbContext
    {
        //Constructor
        public MovieContext(DbContextOptions<MovieContext> options) : base(options)
        {

        }

        public DbSet<Movies> movies { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Movies>().HasData(
                    new Movies
                    {
                        MovieId = 1,
                        Category = "Action/Adventure",
                        Title = "Avengers: End Game",
                        Year = 2019,
                        Director = "Russo Brothers",
                        Rating = "PG-13",
                        Edited = false,
                        Lent = null,
                        Notes = "A classic in 2019!"
                    },

                    new Movies
                    {
                        MovieId = 2,
                        Category = "Action/Adventure",
                        Title = "Interstellar",
                        Year = 2014,
                        Director = "Christopher Nolan",
                        Rating = "PG-13",
                        Edited = false,
                        Lent = null,
                        Notes = "Best movie EVER."
                    },

                    new Movies
                    {
                        MovieId = 3,
                        Category = "Action/Adventure",
                        Title = "Lord of the Rings: The Return of the King ",
                        Year = 2003,
                        Director = "Peter Jackson",
                        Rating = "PG-13",
                        Edited = false,
                        Lent = null,
                        Notes = "One of the all-time classics."
                    }

                );
        }
    }
}