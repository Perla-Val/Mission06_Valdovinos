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
    }
}
