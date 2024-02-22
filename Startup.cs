using Microsoft.EntityFrameworkCore;
using ProjectOrganizer.Data;

public class Startup
{
    private readonly IConfiguration _configuration;

    public Startup(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public void ConfigureTicketServices(IServiceCollection services)
    {
        services.AddDbContext<TicketDbContext>(options =>
            options.UseSqlite(_configuration.GetConnectionString("DefaultConnection")));
    }

    public void ConfigureProjectServices(IServiceCollection services)
    {
        services.AddDbContext<ProjectDbContext>(options =>
            options.UseSqlite(_configuration.GetConnectionString("DefaultConnection")));
    }
}

