using System;
using Microsoft.EntityFrameworkCore;
using AspnetTest.Models;

namespace AspnetTest.Data
{
    public class MvcMovieContext : DbContext
    {
        public MvcMovieContext(DbContextOptions<MvcMovieContext> options) : base(options)
        {

        }

        public DbSet<Movie> Movie { get; set; }
    }
}
