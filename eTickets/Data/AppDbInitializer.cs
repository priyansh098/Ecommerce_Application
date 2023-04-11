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

                        },
                        new Cinemas()
                        {

                        },
                        new Cinemas()
                        {

                        },
                        new Cinemas()
                        {

                        },
                        new Cinemas()
                        {

                        },
                        new Cinemas()
                        {

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

                        },
                        new Actors()
                        {

                        },
                        new Actors()
                        {

                        },
                        new Actors()
                        {

                        },
                        new Actors()
                        {

                        },
                        new Actors()
                        {

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

                        },
                        new Producers()
                        {

                        },
                        new Producers()
                        {

                        },
                        new Producers()
                        {

                        },
                        new Producers()
                        {

                        },
                        new Producers()
                        {

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

                        },
                        new Movies()
                        {

                        },
                        new Movies()
                        {

                        },
                        new Movies()
                        {

                        },
                        new Movies()
                        {

                        },
                        new Movies()
                        {

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

                        },
                        new Actors_Movies()
                        {

                        },
                        new Actors_Movies()
                        {

                        },
                        new Actors_Movies()
                        {

                        },
                        new Actors_Movies()
                        {

                        },
                        new Actors_Movies()
                        {

                        },
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
