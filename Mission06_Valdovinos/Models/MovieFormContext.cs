using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace Mission06_Valdovinos.Models
{
    public class MovieFormContext : DbContext //inhert
    {
        public MovieFormContext(DbContextOptions<MovieFormContext> options) : base (options) 
        {
        }

        public DbSet<Application> Application { get; set; }
        public DbSet<Categories> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) //seed data
        {
            modelBuilder.Entity<Categories>().HasData(
                new Categories { CategoryId =1, CategoryName= "Super Hero"},
                new Categories { CategoryId= 2, CategoryName= "Sci-Fi"},
                new Categories { CategoryId= 3, CategoryName= "Action, Drama, Fantasy" }
              );
        }
    }
}
