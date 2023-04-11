using eTickets.Data.Enums;
using eTickets.Models;

namespace eTickets.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using(var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                context.Database.EnsureCreated();
                //Cinemas
                if(!context.Cinemas.Any())
                {
                    context.Cinemas.AddRange(new List<Cinemas>()
                    {
                        new Cinemas()
                        {
                            Name = "Context1",
                            Logo = "",
                            Description = "It's Context1"
                        },
                        new Cinemas()
                        {
                            Name = "Context2",
                            Logo = "",
                            Description = "It's Context2"
                        },
                        new Cinemas()
                        {
                            Name = "Context3",
                            Logo = "",
                            Description = "It's Context3"
                        },
                        new Cinemas()
                        {
                            Name = "Context4",
                            Logo = "",
                            Description = "It's Context4"
                        },
                        new Cinemas()
                        {
                            Name = "Context5",
                            Logo = "",
                            Description = "It's Context5"
                        },
                        new Cinemas()
                        {
                            Name = "Context6",
                            Logo = "",
                            Description = "It's Context6"
                        },
                    });
                    context.SaveChanges();
                }
                //Actors
                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<Actors>
                    {
                        new Actors()
                        {
                            FullName = "Actor1",
                            Bio = "This is Actor1",
                            ProfilePictureURL = ""
                        },
                        new Actors()
                        {
                            FullName = "Actor2",
                            Bio = "This is Actor2",
                            ProfilePictureURL = ""
                        },
                        new Actors()
                        {
                            FullName = "Actor3",
                            Bio = "This is Actor3",
                            ProfilePictureURL = ""
                        },
                        new Actors()
                        {
                            FullName = "Actor4",
                            Bio = "This is Actor4",
                            ProfilePictureURL = ""
                        },
                        new Actors()
                        {
                            FullName = "Actor5",
                            Bio = "This is Actor5",
                            ProfilePictureURL = ""
                        },
                        new Actors()
                        {
                            FullName = "Actor6",
                            Bio = "This is Actor6",
                            ProfilePictureURL = ""
                        },
                    });
                    context.SaveChanges();
                }
                //Producers
                if (!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<Producers>
                    {
                        new Producers()
                        {
                            FullName = "Producer1",
                            Bio = "It's Producer1",
                            ProfilePictureURL = ""
                        },
                        new Producers()
                        {
                            FullName = "Producer2",
                            Bio = "It's Producer2",
                            ProfilePictureURL = ""
                        },
                        new Producers()
                        {
                            FullName = "Producer3",
                            Bio = "It's Producer3",
                            ProfilePictureURL = ""
                        },
                        new Producers()
                        {
                            FullName = "Producer4",
                            Bio = "It's Producer4",
                            ProfilePictureURL = ""
                        },
                        new Producers()
                        {
                            FullName = "Producer5",
                            Bio = "It's Producer5",
                            ProfilePictureURL = ""
                        },
                        new Producers()
                        {
                            FullName = "Producer6",
                            Bio = "It's Producer6",
                            ProfilePictureURL = ""
                        },
                    });
                    context.SaveChanges();
                }
                //Movies
                if (!context.Movies.Any())
                {
                    context.Movies.AddRange(new List<Movies>
                    {
                        new Movies()
                        {
                            Name = "Movie1",
                            Description = "",
                            Price = 39.50,
                            ImageURL = "",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            CinemaId = 1,
                            ProducerId = 3,
                            MovieCategory = MovieCategory.Drama
                        },
                        new Movies()
                        {
                            Name = "Movie2",
                            Description = "",
                            Price = 39.50,
                            ImageURL = "",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            CinemaId = 1,
                            ProducerId = 3,
                            MovieCategory = MovieCategory.Drama
                        },
                        new Movies()
                        {
                            Name = "Movie3",
                            Description = "",
                            Price = 39.50,
                            ImageURL = "",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            CinemaId = 1,
                            ProducerId = 3,
                            MovieCategory = MovieCategory.Drama
                        },
                        new Movies()
                        {
                            Name = "Movie4",
                            Description = "",
                            Price = 39.50,
                            ImageURL = "",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            CinemaId = 1,
                            ProducerId = 3,
                            MovieCategory = MovieCategory.Drama
                        },
                        new Movies()
                        {
                            Name = "Movie5",
                            Description = "",
                            Price = 39.50,
                            ImageURL = "",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            CinemaId = 1,
                            ProducerId = 3,
                            MovieCategory = MovieCategory.Drama
                        },
                        new Movies()
                        {
                            Name = "Movie6",
                            Description = "",
                            Price = 39.50,
                            ImageURL = "",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            CinemaId = 1,
                            ProducerId = 3,
                            MovieCategory = MovieCategory.Drama
                        },
                    });
                    context.SaveChanges();
                }
                //Actors_Movies
                if (!context.Actors_Movies.Any())
                {
                    context.Actors_Movies.AddRange(new List<Actors_Movies>
                    {
                        new Actors_Movies()
                        {
                            ActorId = 1,
                            MovieId = 2
                        },
                        new Actors_Movies()
                        {
                            ActorId = 1,
                            MovieId = 2
                        },
                        new Actors_Movies()
                        {
                            ActorId = 1,
                            MovieId = 2
                        },
                        new Actors_Movies()
                        {
                            ActorId = 1,
                            MovieId = 2
                        },
                        new Actors_Movies()
                        {
                            ActorId = 1,
                            MovieId = 2
                        },
                        new Actors_Movies()
                        {
                            ActorId = 1,
                            MovieId = 2
                        },
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
