using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
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

        public IList<Ticket> Ticket { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Ticket != null)
            {
                Ticket = await _context.Ticket.ToListAsync();
            }
        }
    }
}
