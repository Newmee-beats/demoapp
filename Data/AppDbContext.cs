using Microsoft.EntityFrameworkCore;
using MyAPP.Models;


namespace MyAPP.Data
{
   public class AppDbContext : DbContext
   {
        protected readonly IConfiguration Configuration;

        public AppDbContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(Configuration.GetConnectionString("DbConnectionString"));
        }
        public DbSet<Person> Persons { get; set; }
   }
}

