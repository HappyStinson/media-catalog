using System.Collections.Generic;
using System.Data.Entity;
using LexiconMDB.Models;

namespace LexiconMDB.DAL
{
    internal sealed class DatabaseContextInitializer : DropCreateDatabaseAlways<LexiconMDBContext>
    {
        protected override void Seed(LexiconMDBContext context)
        {
            context.Movies.AddRange(new List<Movie> {
                new Movie { Title= "New Movie", Genre = "Horror", Length = 95 },
                new Movie { Title= "Horror Movie", Genre = "Horror", Length = 90 },
                new Movie { Title= "New Movie II", Genre = "Comedy", Length = 110 },
                new Movie { Title= "The Shawshank Redemption", Genre = "Drama", Length = 142, ReleaseYear = 1994, IMDbTopRated = true},
                new Movie { Title= "The Godfather", Genre = "Drama", ReleaseYear = 1972, AgeLimit = 15, Metascore = 100, IMDbTopRated = true },
                new Movie { Title= "Revenge of New Movie", Genre = "Drama", Length = 85 }
            });
        }
    }
}