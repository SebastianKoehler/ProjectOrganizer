using System.Collections.Generic;

namespace ProjectOrganizer.Models
{
    public class Project
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public string? Description { get; set; }
        public required string Technologies { get; set; }

        public List<Ticket>? Tickets { get; set; }
    }
}
