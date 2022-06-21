using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BugTracker.Models
{
    public class TicketComment
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public int TicketID { get; set; }

        [Required]
        public string Commenter { get; set; }

        [Required]
        public string CommentText { get; set; }

        [Display(Name = "Date Created")]
        [DataType(DataType.Date)]
        public DateTimeOffset CommentDate { get; set; } = DateTimeOffset.Now;

        public Ticket Ticket { get; set; }
        public User? User { get; set; }
    }
}
