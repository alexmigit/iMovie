using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using iMovie.Models;

namespace iMovie.Data
{
    public class iMovieContext : DbContext
    {
        public iMovieContext (DbContextOptions<iMovieContext> options)
            : base(options)
        {
        }

        public DbSet<iMovie.Models.Movie> Movie { get; set; }
    }
}
