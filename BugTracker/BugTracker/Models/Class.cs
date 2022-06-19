using System.ComponentModel.DataAnnotations;

namespace BugTracker.Models
{
    public class Ticket
    {
        public int TicketID { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string TestNewField { get; set; } = string.Empty;

        [DataType(DataType.Date)]
        public DateTime DateUpdated { get; set; }
        [DataType(DataType.Date)]
        public DateTime DateCreated { get; set; }

    }
}
