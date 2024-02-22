using ProjectOrganizer.Interfaces;
using ProjectOrganizer.Models;
using ProjectOrganizer.Repositories;

namespace ProjectOrganizer.Services
{
    public class TicketService : ITicketService
    {
        private readonly TicketRepository _ticketRepository;

        public TicketService(TicketRepository ticketRepository)
        {
            _ticketRepository = ticketRepository;
        }

        public IEnumerable<Ticket> GetAllTickets()
        {
            return _ticketRepository.GetAllTickets();
        }

        public Ticket? GetTicketById(int id)
        {
            return _ticketRepository.GetTicketById(id);
        }

        public void InsertTicket(Ticket ticket)
        {
            _ticketRepository.InsertTicket(ticket);
        }

        public void UpdateTicket(Ticket ticket)
        {
            _ticketRepository.UpdateTicket(ticket);
        }

        public void DeleteTicket(int id)
        {
            _ticketRepository.DeleteTicket(id);
        }

        public void SaveTicket()
        {
            _ticketRepository.SaveTicket();
        }
    }
}
