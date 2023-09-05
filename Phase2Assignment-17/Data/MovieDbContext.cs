using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Phase2Assignment_17.Models;

namespace Phase2Assignment_17.Data
{
    public class MovieDbContext : DbContext
    {
        public MovieDbContext (DbContextOptions<MovieDbContext> options)
            : base(options)
        {
        }

        public DbSet<Phase2Assignment_17.Models.Movie> Movie { get; set; } = default!;
    }
}
