using Microsoft.EntityFrameworkCore;
using WebTest.Data;

namespace WebTest.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new WebTestContext(
                   serviceProvider.GetRequiredService<
                       DbContextOptions<WebTestContext>>()))
        {
            if (context == null || context.Movie == null)
            {
                throw new ArgumentNullException("serviceProvider");
            }

            // Look for any movies.
            if (context.Movie.Any())
            {
                return;   // DB has been seeded
            }

            context.Movie.AddRange(
                new Movie
                {
                    Title = "When Harry Met Sally",
                    ReleaseDate = DateTime.Parse("1989-2-12"),
                    Genre = "Romantic Comedy",
                    Price = 7.99M
                },

                new Movie
                {
                    Title = "Ghostbusters ",
                    ReleaseDate = DateTime.Parse("1984-3-13"),
                    Genre = "Comedy",
                    Price = 8.99M
                },

                new Movie
                {
                    Title = "Ghostbusters 2",
                    ReleaseDate = DateTime.Parse("1986-2-23"),
                    Genre = "Comedy",
                    Price = 9.99M
                },

                new Movie
                {
                    Title = "Rio Bravo",
                    ReleaseDate = DateTime.Parse("1959-4-15"),
                    Genre = "Western",
                    Price = 3.99M
                },
                new Movie
                {
                    Title = "The Godfather",
                    ReleaseDate = DateTime.Parse("1972-3-24"),
                    Genre = "Crime",
                    Price = 4.99M
                },
                new Movie
                {
                    Title = "The Shawshank Redemption",
                    ReleaseDate = DateTime.Parse("1994-9-23"),
                    Genre = "Drama",
                    Price = 3.99M
                },
                new Movie
                {
                    Title = "Schindler's List",
                    ReleaseDate = DateTime.Parse("1993-12-15"),
                    Genre = "Biography",
                    Price = 4.49M
                },
                new Movie
                {
                    Title = "Pulp Fiction",
                    ReleaseDate = DateTime.Parse("1994-10-14"),
                    Genre = "Crime",
                    Price = 3.99M
                },
                new Movie
                {
                    Title = "The Dark Knight",
                    ReleaseDate = DateTime.Parse("2008-7-18"),
                    Genre = "Action",
                    Price = 4.99M
                },
                new Movie
                {
                    Title = "The Lord of the Rings: The Return of the King",
                    ReleaseDate = DateTime.Parse("2003-12-17"),
                    Genre = "Fantasy",
                    Price = 4.99M
                },
                new Movie
                {
                    Title = "Forrest Gump",
                    ReleaseDate = DateTime.Parse("1994-7-6"),
                    Genre = "Drama",
                    Price = 3.99M
                },
                new Movie
                {
                    Title = "Inception",
                    ReleaseDate = DateTime.Parse("2010-7-16"),
                    Genre = "Sci-Fi",
                    Price = 4.49M
                },
                new Movie
                {
                    Title = "Fight Club",
                    ReleaseDate = DateTime.Parse("1999-10-15"),
                    Genre = "Drama",
                    Price = 3.99M
                },
                new Movie
                {
                    Title = "The Matrix",
                    ReleaseDate = DateTime.Parse("1999-3-31"),
                    Genre = "Sci-Fi",
                    Price = 3.99M
                },
                new Movie
                {
                    Title = "Goodfellas",
                    ReleaseDate = DateTime.Parse("1990-9-19"),
                    Genre = "Crime",
                    Price = 4.49M
                },
                new Movie
                {
                    Title = "Star Wars: Episode V - The Empire Strikes Back",
                    ReleaseDate = DateTime.Parse("1980-5-21"),
                    Genre = "Sci-Fi",
                    Price = 3.99M
                },
                new Movie
                {
                    Title = "The Silence of the Lambs",
                    ReleaseDate = DateTime.Parse("1991-2-14"),
                    Genre = "Thriller",
                    Price = 3.99M
                },
                new Movie
                {
                    Title = "Saving Private Ryan",
                    ReleaseDate = DateTime.Parse("1998-7-24"),
                    Genre = "War",
                    Price = 4.99M
                },
                new Movie
                {
                    Title = "Jurassic Park",
                    ReleaseDate = DateTime.Parse("1993-6-11"),
                    Genre = "Adventure",
                    Price = 3.99M
                },
                new Movie
                {
                    Title = "The Lion King",
                    ReleaseDate = DateTime.Parse("1994-6-15"),
                    Genre = "Animation",
                    Price = 3.99M
                },
                new Movie
                {
                    Title = "Back to the Future",
                    ReleaseDate = DateTime.Parse("1985-7-3"),
                    Genre = "Adventure",
                    Price = 3.99M
                },
                new Movie
                {
                    Title = "Titanic",
                    ReleaseDate = DateTime.Parse("1997-12-19"),
                    Genre = "Romance",
                    Price = 4.99M
                },
                new Movie
                {
                    Title = "The Avengers",
                    ReleaseDate = DateTime.Parse("2012-5-4"),
                    Genre = "Action",
                    Price = 4.99M
                },
                new Movie
                {
                    Title = "The Terminator",
                    ReleaseDate = DateTime.Parse("1984-10-26"),
                    Genre = "Sci-Fi",
                    Price = 4.99M
                },
                new Movie
                {
                    Title = "Braveheart",
                    ReleaseDate = DateTime.Parse("1995-5-24"),
                    Genre = "History",
                    Price = 4.49M
                },
                new Movie
                {
                    Title = "A Beautiful Mind",
                    ReleaseDate = DateTime.Parse("2001-12-21"),
                    Genre = "Biography",
                    Price = 4.99M
                },
                new Movie
                {
                    Title = "Avatar",
                    ReleaseDate = DateTime.Parse("2009-12-18"),
                    Genre = "Sci-Fi",
                    Price = 4.99M
                },
                new Movie
                {
                    Title = "The Departed",
                    ReleaseDate = DateTime.Parse("2006-10-6"),
                    Genre = "Crime",
                    Price = 4.49M
                },
                new Movie
                {
                    Title = "The Prestige",
                    ReleaseDate = DateTime.Parse("2006-10-20"),
                    Genre = "Drama",
                    Price = 3.99M
                },
                new Movie
                {
                    Title = "Memento",
                    ReleaseDate = DateTime.Parse("2000-10-11"),
                    Genre = "Mystery",
                    Price = 4.49M
                },
                new Movie
                {
                    Title = "The Green Mile",
                    ReleaseDate = DateTime.Parse("1999-12-10"),
                    Genre = "Drama",
                    Price = 3.99M
                },
                new Movie
                {
                    Title = "Alien",
                    ReleaseDate = DateTime.Parse("1979-5-25"),
                    Genre = "Horror",
                    Price = 4.99M
                },
                new Movie
                {
                    Title = "Gladiator",
                    ReleaseDate = DateTime.Parse("2000-5-5"),
                    Genre = "Action",
                    Price = 4.49M
                },
                new Movie
                {
                    Title = "Casablanca",
                    ReleaseDate = DateTime.Parse("1942-11-26"),
                    Genre = "Romance",
                    Price = 3.99M
                },
                new Movie
                {
                    Title = "The Truman Show",
                    ReleaseDate = DateTime.Parse("1998-6-5"),
                    Genre = "Drama",
                    Price = 3.99M
                },
                new Movie
                {
                    Title = "Die Hard",
                    ReleaseDate = DateTime.Parse("1988-7-20"),
                    Genre = "Action",
                    Price = 4.49M
                },
                new Movie
                {
                    Title = "The Sixth Sense",
                    ReleaseDate = DateTime.Parse("1999-8-6"),
                    Genre = "Thriller",
                    Price = 4.99M
                },
                new Movie
                {
                    Title = "Jaws",
                    ReleaseDate = DateTime.Parse("1975-6-20"),
                    Genre = "Thriller",
                    Price = 4.99M
                },
                new Movie
                {
                    Title = "E.T. the Extra-Terrestrial",
                    ReleaseDate = DateTime.Parse("1982-6-11"),
                    Genre = "Family",
                    Price = 3.99M
                },
                new Movie
                {
                    Title = "The Wizard of Oz",
                    ReleaseDate = DateTime.Parse("1939-8-25"),
                    Genre = "Fantasy",
                    Price = 3.99M
                },
                new Movie
                {
                    Title = "Rocky",
                    ReleaseDate = DateTime.Parse("1976-12-3"),
                    Genre = "Drama",
                    Price = 4.49M
                },
                new Movie
                {
                    Title = "Apocalypse Now",
                    ReleaseDate = DateTime.Parse("1979-8-15"),
                    Genre = "War",
                    Price = 4.99M
                },
                new Movie
                {
                    Title = "Mad Max: Fury Road",
                    ReleaseDate = DateTime.Parse("2015-5-15"),
                    Genre = "Action",
                    Price = 4.99M
                }
            );
            context.SaveChanges();
        }
    }
}