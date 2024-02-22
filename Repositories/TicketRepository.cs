using ProjectOrganizer.Data;
using ProjectOrganizer.Interfaces;
using ProjectOrganizer.Models;

namespace ProjectOrganizer.Repositories
{
    public class TicketRepository : ITicketRepository, IDisposable
    {
        private TicketDbContext _dbContext;
        private bool disposed = false;

        public TicketRepository(TicketDbContext dbContext)
        {  
            _dbContext = dbContext; 
        }

        public IEnumerable<Ticket> GetAllTickets()
        {
            return _dbContext.Tickets.ToList();
        }

        public Ticket? GetTicketById(int id)
        {
            return _dbContext.Tickets.Find(id);
        }

        public void InsertTicket(Ticket ticket)
        {
            _dbContext.Add(ticket);
        }

        public void UpdateTicket(Ticket ticket)
        {
            _dbContext.Update(ticket);
        }

        public void DeleteTicket(int id)
        {
            Ticket? ticket = _dbContext.Tickets.Find(id);

            if (ticket != null)
            {
                _dbContext.Remove(ticket);
            }
            else
            {
                Console.WriteLine("Not found");
            }
        }

        public void SaveTicket()
        {
            _dbContext.SaveChanges();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    _dbContext.Dispose();
                }
            }
            disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
