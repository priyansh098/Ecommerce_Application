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
                            Logo = "http://dotnethow.net/images/cinemas/cinema-1.jpeg",
                            Description = "This is the description of the first cinema"
                        },
                        new Cinemas()
                        {
                            Name = "Context2",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-2.jpeg",
                            Description = "This is the description of the second cinema"
                        },
                        new Cinemas()
                        {
                            Name = "Context3",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-3.jpeg",
                            Description = "This is the description of the third cinema"
                        },
                        new Cinemas()
                        {
                            Name = "Context4",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-4.jpeg",
                            Description = "This is the description of the fourth cinema"
                        },
                        new Cinemas()
                        {
                            Name = "Context5",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-5.jpeg",
                            Description = "This is the description of the fourth cinema"
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
                            Bio = "This is the Bio of the first actor",
                            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-1.jpeg"
                        },
                        new Actors()
                        {
                            FullName = "Actor2",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-2.jpeg"
                        },
                        new Actors()
                        {
                            FullName = "Actor3",
                            Bio = "This is the Bio of the third actor",
                            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-3.jpeg"
                        },
                        new Actors()
                        {
                            FullName = "Actor4",
                            Bio = "This is the Bio of the fourth actor",
                            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-4.jpeg"
                        },
                        new Actors()
                        {
                            FullName = "Actor5",
                            Bio = "This is the Bio of the fifth actor",
                            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-5.jpeg"
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
                            Bio = "This is the Bio of the first actor",
                            ProfilePictureURL = "http://dotnethow.net/images/producers/producer-1.jpeg"
                        },
                        new Producers()
                        {
                            FullName = "Producer2",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "http://dotnethow.net/images/producers/producer-2.jpeg"
                        },
                        new Producers()
                        {
                            FullName = "Producer3",
                            Bio = "This is the Bio of the third actor",
                            ProfilePictureURL = "http://dotnethow.net/images/producers/producer-3.jpeg"
                        },
                        new Producers()
                        {
                            FullName = "Producer4",
                            Bio = "This is the Bio of the fourth actor",
                            ProfilePictureURL = "http://dotnethow.net/images/producers/producer-4.jpeg"
                        },
                        new Producers()
                        {
                            FullName = "Producer5",
                            Bio = "This is the Bio of the fifth actor",
                            ProfilePictureURL = "http://dotnethow.net/images/producers/producer-5.jpeg"
                        },
                    });
                    context.SaveChanges();
                }
                //Movies
                if (!context.Movies.Any())
                { 
                    Movies movies = new Movies();
                    movies.Name = "life";
                    movies.Description = "This is the Life movie description";
                    movies.Price = 39.50;
                    movies.ImageURL = "http://dotnethow.net/images/movies/movie-3.jpeg";
                    movies.StartDate = DateTime.Now.AddDays(-10);
                    movies.EndDate = DateTime.Now.AddDays(10);
                    movies.CinemaId = 4;
                    movies.ProducerId = 3;
                    movies.MovieCategory = MovieCategory.Documentary;
                        
                    context.Movies.Add(movies);
                    //context.Movies.AddRange(new List<Movies>
                    //{
                    //    new Movies()
                    //    {
                    //        Name = "Life",
                    //        Description = "This is the Life movie description",
                    //        Price = 39.50,
                    //        ImageURL = "http://dotnethow.net/images/movies/movie-3.jpeg",
                    //        StartDate = DateTime.Now.AddDays(-10),
                    //        EndDate = DateTime.Now.AddDays(10),
                    //        CinemaId = 3,
                    //        ProducerId = 3,
                    //        MovieCategory = MovieCategory.Documentary
                    //    },
                    //    new Movies()
                    //    {
                    //        Name = "The Shawshank Redemption",
                    //        Description = "This is the Shawshank Redemption description",
                    //        Price = 29.50,
                    //        ImageURL = "http://dotnethow.net/images/movies/movie-1.jpeg",
                    //        StartDate = DateTime.Now,
                    //        EndDate = DateTime.Now.AddDays(3),
                    //        CinemaId = 1,
                    //        ProducerId = 1,
                    //        MovieCategory = MovieCategory.Action
                    //    },
                    //    new Movies()
                    //    {
                    //        Name = "Ghost",
                    //        Description = "This is the Ghost movie description",
                    //        Price = 39.50,
                    //        ImageURL = "http://dotnethow.net/images/movies/movie-4.jpeg",
                    //        StartDate = DateTime.Now,
                    //        EndDate = DateTime.Now.AddDays(7),
                    //        CinemaId = 4,
                    //        ProducerId = 4,
                    //        MovieCategory = MovieCategory.Horror
                    //    },
                    //    new Movies()
                    //    {
                    //        Name = "Race",
                    //        Description = "This is the Race movie description",
                    //        Price = 39.50,
                    //        ImageURL = "http://dotnethow.net/images/movies/movie-6.jpeg",
                    //        StartDate = DateTime.Now.AddDays(-10),
                    //        EndDate = DateTime.Now.AddDays(-5),
                    //        CinemaId = 1,
                    //        ProducerId = 2,
                    //        MovieCategory = MovieCategory.Documentary
                    //    },
                    //    new Movies()
                    //    {
                    //        Name = "Scoob",
                    //        Description = "This is the Scoob movie description",
                    //        Price = 39.50,
                    //        ImageURL = "http://dotnethow.net/images/movies/movie-7.jpeg",
                    //        StartDate = DateTime.Now.AddDays(-10),
                    //        EndDate = DateTime.Now.AddDays(-2),
                    //        CinemaId = 1,
                    //        ProducerId = 3,
                    //        MovieCategory = MovieCategory.Cartoon
                    //    },
                    //    new Movies()
                    //    {
                    //        Name = "Cold Soles",
                    //        Description = "This is the Cold Soles movie description",
                    //        Price = 39.50,
                    //        ImageURL = "http://dotnethow.net/images/movies/movie-8.jpeg",
                    //        StartDate = DateTime.Now.AddDays(3),
                    //        EndDate = DateTime.Now.AddDays(20),
                    //        CinemaId = 1,
                    //        ProducerId = 5,
                    //        MovieCategory = MovieCategory.Drama
                    //    },
                    //});
                    context.SaveChanges();
                }
                //Actors_Movies
                if (!context.Actors_Movies.Any())
                {
                    context.Actors_Movies.AddRange(new List<Actors_Movies>
                    {
                        new Actors_Movies()
                        {
                            Actors=new Actors
                            {
                                FullName="",
                                Bio="",
                                ProfilePictureURL="",
                                
                            },
                            MovieId=19
                        },
                        new Actors_Movies()
                        {
                            Actors=new Actors
                            {
                                FullName="",
                                Bio="",
                                ProfilePictureURL="",

                            },
                            MovieId=20
                        },

                         new Actors_Movies()
                        {
                            Actors=new Actors
                            {
                                FullName="",
                                Bio="",
                                ProfilePictureURL="",

                            },
                            MovieId=19
                        },
                         new Actors_Movies()
                        {
                            Actors=new Actors
                            {
                                FullName="",
                                Bio="",
                                ProfilePictureURL="",

                            },
                            MovieId=19
                        },

                        new Actors_Movies()
                        {
                            Actors=new Actors
                            {
                                FullName="",
                                Bio="",
                                ProfilePictureURL="",

                            },
                            MovieId=19
                        }
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
