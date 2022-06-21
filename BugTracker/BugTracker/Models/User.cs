using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BugTracker.Models
{
    public enum Role
    {
        Admin, Lead, Developer, Tester, EndUser
    }
    public class User
    {
        public int ID { get; set; }

        [Required]
        public string UserName { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }

        [Display(Name = "Full Name")]
        public string FullName
        {
            get { return FirstName + " " + LastName; }
        }

        [Required]
        public Role Role { get; set; }

        public ICollection<TicketComment> TicketComments { get; set; }

    }
}
