using Microsoft.EntityFrameworkCore;

namespace CoreWebApp.Data
{
    public class TicketSystemDbContext :DbContext
    {
        public DbSet<Ticket> Tickets { get; set; }
        public TicketSystemDbContext()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = TicketSystemData");
        }
    }
}
