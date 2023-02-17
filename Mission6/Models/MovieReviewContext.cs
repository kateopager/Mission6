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

    }
}
