using Microsoft.EntityFrameworkCore;
using ProjectOrganizer.Models;

namespace ProjectOrganizer.Data
{
    public class ProjectDbContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public ProjectDbContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite(Configuration.GetConnectionString("DefaultConnection"));
        }

        public DbSet<Project> Projects { get; set; }
    }
}
