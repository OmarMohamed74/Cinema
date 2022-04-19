using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace eTickets.Models.Data
{
    public class AppDbContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=eTickets;Integrated Security=True");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actor_Movie>().HasKey(am => new { am.MovieId, am.ActorId });
            base.OnModelCreating(modelBuilder);
        }


        public virtual DbSet<Actor> Actors { get; set; }
        public virtual DbSet<Cinema> Cinemas { get; set; }
        public virtual DbSet<Movie> Movies { get; set; }

        internal EntityEntry Entry<T>(object entity)
        {
            throw new NotImplementedException();
        }

        public virtual DbSet<Producer> Producers { get; set; }

        public virtual DbSet<Actor_Movie> Actors_Movies { get; set; }



    }
}
