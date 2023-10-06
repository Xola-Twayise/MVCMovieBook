using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using MVCBookMovie.Models;

namespace MVCBookMovie.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<MVCBookMovie.Models.Book> Book { get; set; }
        public DbSet<MVCBookMovie.Models.Movie> Movie { get; set; }
    }
}
