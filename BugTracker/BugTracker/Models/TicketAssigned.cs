using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BugTracker.Models
{
    public class TicketAssigned
    {
        public int ID { get; set; }

        public int? UserID { get; set; }

        public int? TicketID { get; set; }

        public User? User { get; set; }
        public Ticket? Ticket { get; set; }
    }
}
