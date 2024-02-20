namespace ProjectOrganizer.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public required string Description { get; set; }
        public required string Status { get; set; }

        public required int ProjectId { get; set; }
        public required Project Project { get; set; }
    }
}
