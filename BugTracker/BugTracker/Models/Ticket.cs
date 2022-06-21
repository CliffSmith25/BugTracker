using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BugTracker.Models
{
    public enum Priority
    {
        Critical, High, Medium, Low
    }
    public enum TicketState
    {
        New, Rejected, Open, Deferred, Fixed, Test, Reopen, Closed, Duplicate
    }

    public enum TicketType
    {
        Bug, Improvement
    }
    public class Ticket
    {
        //[RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        public int ID { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Title { get; set; } = string.Empty;

        [Required]
        public string Description { get; set; } = string.Empty;

        [Required]
        public Priority Priority { get; set; } = Priority.Low;

        public int UserID { get; set; }

        [Required]
        public User? CreatedBy { get; set; }

        [Required]
        public TicketType TType { get; set; }

        [Display(Name = "Date Updated")]
        [DataType(DataType.Date)]
        public DateTimeOffset DateUpdated { get; set; }

        [Display(Name = "Date Created")]
        [DataType(DataType.Date)]
        public DateTimeOffset DateCreated { get; set; } = DateTimeOffset.Now;

        public ICollection<TicketComment> TicketComments { get; set; }

    }
}
