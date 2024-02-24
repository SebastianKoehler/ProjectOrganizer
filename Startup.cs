using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using ProjectOrganizer.Data;
using ProjectOrganizer.Services;

public class Startup
{
    private readonly IConfiguration _configuration;

    public Startup(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddDbContext<ProjectOrganizerDbContext>(options =>
            options.UseSqlite(_configuration.GetConnectionString("DefaultConnection")));

        services.AddScoped<ProjectService>();
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
