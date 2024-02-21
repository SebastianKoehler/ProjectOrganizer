using Microsoft.EntityFrameworkCore;
using ProjectOrganizer.Models;

namespace ProjectOrganizer.Data
{
    public class TicketDbContext : DbContext
    {
        public TicketDbContext(DbContextOptions<TicketDbContext> options) : base(options) {
        
        }

        public DbSet<Ticket> Tickets { get; set; }
        
    }
}
