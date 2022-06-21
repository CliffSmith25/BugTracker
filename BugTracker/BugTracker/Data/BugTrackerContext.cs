using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BugTracker.Models;

namespace BugTracker.Data
{
    public class BugTrackerContext : DbContext
    {
        public BugTrackerContext(DbContextOptions<BugTrackerContext> options)
            : base(options)
        {
        }

        public DbSet<BugTracker.Models.Ticket>? Tickets { get; set; }
        //public DbSet<BugTracker.Models.TicketComment>? TicketComments { get; set; }
        public DbSet<BugTracker.Models.User>? Users { get; set; }
        public DbSet<BugTracker.Models.TicketAssigned>? TicketsAssigned { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TicketComment>()
                .HasOne(t => t.User)
                .WithMany(c => c.TicketComments)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
