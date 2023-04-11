using eTickets.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace eTickets.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actors_Movies>().HasKey(e => new {e.ActorId, e.MovieId});
            modelBuilder.Entity<Actors_Movies>().HasOne(e => e.Movies).WithMany(e => e.Actors_Movies).HasForeignKey(e => e.MovieId);
            modelBuilder.Entity<Actors_Movies>().HasOne(e => e.Actors).WithMany(e => e.Actors_Movies).HasForeignKey(e => e.ActorId);
            
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Actors> Actors { get; set; }
        public DbSet<Movies> Movies { get; set; }
        public DbSet<Actors_Movies> Actors_Movies { get; set; }
        public DbSet<Cinemas> Cinemas { get; set; }
        public DbSet<Producers> Producers { get; set; }
    }
}