using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BugTracker.Data;
using BugTracker.Models;

namespace BugTracker.Pages.Tickets
{
    public class IndexModel : PageModel
    {
        private readonly BugTracker.Data.BugTrackerContext _context;

        public IndexModel(BugTracker.Data.BugTrackerContext context)
        {
            _context = context;
        }

        public IList<Ticket> Ticket { get; set; } = default!;

        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public SelectList Statuses { get; set; }

        [BindProperty(SupportsGet = true)]
        public string TicketStatus { get; set; }

        public async Task OnGetAsync()
        {
            var tickets = from t in _context.Tickets select t;

            if (!string.IsNullOrEmpty(SearchString))
            {
                tickets = tickets.Where(s => s.Title.Contains(SearchString));
            }

            Ticket = await tickets.ToListAsync();
        }
    }
}
