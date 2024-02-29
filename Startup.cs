using Microsoft.EntityFrameworkCore;
using ProjectOrganizer.Data;
using ProjectOrganizer.Services;
using ProjectOrganizer.Interfaces;
using ProjectOrganizer.Repositories;

public class Startup
{
    private readonly IConfiguration _configuration;

    public Startup(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddRazorPages();

        // DbContext registrieren
        services.AddDbContext<ProjectOrganizerDbContext>(options =>
            options.UseSqlite(_configuration.GetConnectionString("DefaultConnection")));

        // Services und Repositories registrieren
        services.AddScoped<IProjectService, ProjectService>();
        services.AddScoped<ITicketService, TicketService>();
        services.AddScoped<IProjectRepository, ProjectRepository>();
        services.AddScoped<ITicketRepository, TicketRepository>();

        // Andere Dienste registrieren
        services.AddLogging();
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        using (var scope = app.ApplicationServices.CreateScope()) 
        { 
            var services = scope.ServiceProvider;
            var context = services.GetRequiredService<ProjectOrganizerDbContext>();
            context.Database.EnsureCreated();
            context.Database.Migrate();
        }
    }
}
