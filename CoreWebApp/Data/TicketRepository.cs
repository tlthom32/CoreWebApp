namespace CoreWebApp.Data
{
    public class TicketRepository:ITicketRepository
    {
        private readonly TicketSystemDbContext _ticketSystemDbContext;

        public TicketRepository()
        {
            _ticketSystemDbContext = new TicketSystemDbContext();
        }
        public bool AddTicket(Ticket ticket)
        {
            var rc = false;

            _ticketSystemDbContext.Tickets.Add(ticket);

            return rc;
        }
    }
}
    