using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace MvcMovieChrisBrown.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieChrisBrownContext(
                serviceProvider.GetRequiredService<DbContextOptions<MvcMovieChrisBrownContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                     new Movie
                     {
                         Title = "Gods Army",
                         ReleaseDate = DateTime.Parse("2000-3-10"),
                         Genre = "Drama",
                         Rating = "PG",
                         Price = 7.99M
                     },

                     new Movie
                     {
                         Title = "Baptists At Our Barbeque",
                         ReleaseDate = DateTime.Parse("2004-10-8"),
                         Genre = "Romantic Comedy",
                         Rating = "PG",
                         Price = 8.99M
                     },

                     new Movie
                     {
                         Title = "The R.M.",
                         ReleaseDate = DateTime.Parse("2003-1-31"),
                         Genre = "Comedy",
                         Rating = "PG",
                         Price = 9.99M
                     },

                   new Movie
                   {
                       Title = "The Saratov Approach",
                       ReleaseDate = DateTime.Parse("2013-10-9"),
                       Genre = "Thriller",
                       Rating = "PG-13",
                       Price = 13.99M
                   },

                   new Movie
                   {
                       Title = "The Best Two Years",
                       ReleaseDate = DateTime.Parse("2004-2-20"),
                       Genre = "Comedy",
                       Rating = "PG",
                       Price = 3.99M
                   },

                   new Movie
                   {
                       Title = "Saints and Soldiers",
                       ReleaseDate = DateTime.Parse("2005-3-25"),
                       Genre = "Drama",
                       Rating = "PG-13",
                       Price = 13.99M
                   }
                );
                context.SaveChanges();
            }
        }
    }
}
