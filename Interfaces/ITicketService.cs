using ProjectOrganizer.Models;

namespace ProjectOrganizer.Interfaces
{
    public interface ITicketService
    {
        IEnumerable<Ticket> GetAllTickets();
        Ticket? GetTicketById(int id);
        void InsertTicket(Ticket ticket);
        void UpdateTicket(Ticket ticket);
        void DeleteTicket(int id);
        void SaveTicket();
    }
}
