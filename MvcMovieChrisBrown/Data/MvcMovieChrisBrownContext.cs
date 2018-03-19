using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MvcMovieChrisBrown.Models
{
    public class MvcMovieChrisBrownContext : DbContext
    {
        public MvcMovieChrisBrownContext (DbContextOptions<MvcMovieChrisBrownContext> options)
            : base(options)
        {
        }

        public DbSet<MvcMovieChrisBrown.Models.Movie> Movie { get; set; }
    }
}
