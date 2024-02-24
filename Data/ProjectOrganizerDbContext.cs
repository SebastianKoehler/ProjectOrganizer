using Microsoft.EntityFrameworkCore;
using ProjectOrganizer.Models;

namespace ProjectOrganizer.Data
{
    public class ProjectOrganizerDbContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public ProjectOrganizerDbContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite(Configuration.GetConnectionString("DefaultConnection"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Project>().HasData(
                new Project { 
                    Id = 1, 
                    Name = "Taschenrechner", 
                    Description = "Simpler Taschenrechner programmiert in Python", 
                    Technologies = "Python, Tkinter"}
                );

            modelBuilder.Entity<Ticket>().HasData(
                new Ticket {
                    Id = 1,
                    ProjectId = 1,
                    Title = "GUI Design",
                    Description = "Erstelle ein erstes Design Konzept mit Tkinter.",
                    Status = "Backlog"}
                );
        }

        public DbSet<Project> Projects { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
    }
}
