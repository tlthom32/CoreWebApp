using System.ComponentModel.DataAnnotations;

namespace CoreWebApp.Data
{
    public class Ticket
    {
        [Key]
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime DateSubmitted { get; set; }
        public string SubmittedByEmail { get; set; }


    }
}
