﻿using Microsoft.EntityFrameworkCore;
using ProjectOrganizer.Models;

namespace ProjectOrganizer.Data
{
    public class TicketDbContext : DbContext
    {
        protected readonly IConfiguration Configuration;
        public TicketDbContext(IConfiguration configuration) 
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite(Configuration.GetConnectionString("DefaultConnection"));
        }

        public DbSet<Ticket> Tickets { get; set; }
        
    }
}