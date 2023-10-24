
using Microsoft.EntityFrameworkCore;

namespace EasyDinnerApi.Data
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext(DbContextOptions options) : base(options)
        { 
        }
        //protected readonly IConfiguration Configuration;

        //public ApiDbContext(IConfiguration configuration)
        //{
        //    Configuration = configuration;
        //}

        //protected override void OnConfiguring(DbContextOptionsBuilder options)
        //{
        //    options.UseNpgsql(Configuration.GetConnectionString("WebApiDatabase"));
        //}

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Recipe>().HasKey(r => r.Recipe_Id); 
        }

        public DbSet<Recipe> Recipes { get; set; } 
    }
}
