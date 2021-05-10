using Microsoft.EntityFrameworkCore;
using Bcc.Models;

namespace Bcc.Data
{
    public class BccContext : DbContext
    {
        public BccContext (DbContextOptions<BccContext>options) : base(options)
        {
        }

        public DbSet<Movie> Movie {get; set;}
        public DbSet<Actor> Actor {get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actor>()
                .HasOne(a => a.Movie)
                .WithMany(m => m.Actors);

            base.OnModelCreating(modelBuilder);
        }
    }
}