using Microsoft.EntityFrameworkCore;
using System.Reflection;
using WelcomeToTheZoo.API.Domain;

namespace WelcomeToTheZoo.API.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Animal>? Animals { get; set; }

        public DbSet<Zoo>? Zoos { get; set; }

        public DbSet<User>? Users { get; set; }

        public DataContext()
        {
        }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            modelBuilder.Entity<Animal>()
                .HasOne(animal => animal.Zoo)
                .WithMany(zoo => zoo.Animals)
                .HasForeignKey(animal => animal.ZooId);
        }
    }
}
