using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission6.Models
{
    public class MovieReviewContext : DbContext
    {
        //this is the constructor that has been created to run when built
        public MovieReviewContext (DbContextOptions<MovieReviewContext> options) : base (options)
        {

        }
        public DbSet<ApplicationResponse> responses { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<ApplicationResponse>().HasData(
                new ApplicationResponse
                {
                    MovieReviewID = 1,
                    Title = "High School Musical",
                    Category = "Musical",
                    Year = 2006,
                    Director = "Kenny Ortega",
                    Rating = "G",
                    Edited = false,
                    LentTo = "NA",
                    Notes = "NA"
                },
                new ApplicationResponse
                {
                    MovieReviewID = 2,
                    Title = "High School Musical 2",
                    Category = "Musical",
                    Year = 2007,
                    Director = "Kenny Ortega",
                    Rating = "G",
                    Edited = true,
                    LentTo = "NA",
                    Notes = "NA"
                },
                new ApplicationResponse
                {
                    MovieReviewID = 3,
                    Title = "High School Musical 3: Senior Year",
                    Category = "Musical",
                    Year = 2008,
                    Director="Kenny Ortega",
                    Rating= "G",
                    Edited= false,
                    LentTo= "NA",
                    Notes= "NA"
                }

                ) ;
        }
    }
}
