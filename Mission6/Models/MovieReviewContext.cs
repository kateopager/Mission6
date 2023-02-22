using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission7.Models
{
    public class MovieReviewContext : DbContext
    {
        //this is the constructor that has been created to run when built
        public MovieReviewContext(DbContextOptions<MovieReviewContext> options) : base(options)
        {

        }

        public DbSet<ApplicationResponse> Responses { get; set; }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Category>().HasData(
                new Category
                {
                    CategoryID = 1,
                    CategoryName = "Musical"
                },
                new Category
                {
                    CategoryID = 2,
                    CategoryName = "Action"
                });


            mb.Entity<ApplicationResponse>().HasData(
                new ApplicationResponse
                {
                    MovieReviewID = 1,
                    Title = "High School Musical",
                    CategoryID = 1,
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
                    CategoryID = 1,
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
                    CategoryID = 1,
                    Year = 2008,
                    Director = "Kenny Ortega",
                    Rating = "G",
                    Edited = false,
                    LentTo = "NA",
                    Notes = "NA"
                }

                );
        } 
    }
}
