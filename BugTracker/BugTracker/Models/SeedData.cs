using Microsoft.EntityFrameworkCore;
using BugTracker.Data;

namespace BugTracker.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new BugTrackerContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<BugTrackerContext>>()))
            {
                if (context == null || context.Tickets == null)
                {
                    throw new ArgumentNullException("Null BugTrackerContext");
                }

                // Look for any tickets.
                if (context.Tickets.Any())
                {
                    return; //DB has been seeded
                }

                var users = new User[]
                {
                    new User{LastName="Smith",FirstName="Caitlin",UserName="CaSmith",Role=Role.Lead},
                    new User{LastName="Alexander",FirstName="Carson",UserName="CaAlex",Role=Role.Lead},
                    new User{LastName="Smith",FirstName="Megan",UserName="MeSmith",Role=Role.Tester},
                    new User{LastName="Li",FirstName="Yan",UserName="YaLi",Role=Role.Tester},
                    new User{LastName="Zuckerburg",FirstName="Mark",UserName="MaZucker",Role=Role.Admin},
                    new User{LastName="Einstein",FirstName="Albert",UserName="AlEins",Role=Role.Admin},
                    new User{LastName="Norman",FirstName="Laura",UserName="LaNorman",Role=Role.Developer},
                    new User{LastName="Olivetto",FirstName="Nino",UserName="NiOlivetto",Role=Role.Developer},
                    new User{LastName="Smith",FirstName="Cliff",UserName="ClSmith",Role=Role.EndUser},
                    new User{LastName="McStinks",FirstName="Stinky",UserName="StMcStinks",Role=Role.EndUser},
                };

                context.Users.AddRange(users);
                context.SaveChanges();

                context.Tickets.AddRange(
                    new Ticket
                    {
                        Title = "Can't Open Tickets",
                        Description = "I cannot view the details of the ticket",
                        DateCreated = DateTimeOffset.UtcNow,
                        Priority = Priority.High,
                        DateUpdated = DateTimeOffset.UtcNow,
                        UserID = 1,
                        TType = TicketType.Bug,
                    },

                    new Ticket
                    {
                        Title = "This bug tracker sucks",
                        Description = "Make a better bug tracker",
                        DateCreated = DateTimeOffset.UtcNow,
                        Priority = Priority.Low,
                        DateUpdated = DateTimeOffset.UtcNow,
                        UserID = 2,
                        TType = TicketType.Improvement,
                    },

                    new Ticket
                    {
                        Title = "Can't update ticket",
                        Description = "I'm logged in as admin but I can't update tickets",
                        DateCreated = DateTimeOffset.UtcNow,
                        Priority = Priority.Critical,
                        DateUpdated = DateTimeOffset.UtcNow,
                        UserID = 3,
                        TType = TicketType.Improvement,
                    },

                    new Ticket
                    {
                        Title = "Can't update ticket",
                        Description = "I'm logged in as admin but I can't update tickets",
                        DateCreated = DateTimeOffset.UtcNow,
                        Priority = Priority.Critical,
                        DateUpdated = DateTimeOffset.UtcNow,
                        UserID = 4,
                        TType = TicketType.Bug,
                    },

                    new Ticket
                    {
                        Title = "Can't update ticket",
                        Description = "I'm logged in as admin but I can't update tickets",
                        DateCreated = DateTimeOffset.UtcNow,
                        Priority = Priority.Critical,
                        DateUpdated = DateTimeOffset.UtcNow,
                        UserID = 5,
                        TType = TicketType.Bug,
                    },

                    new Ticket
                    {
                        Title = "Can't update ticket",
                        Description = "I'm logged in as admin but I can't update tickets",
                        DateCreated = DateTimeOffset.UtcNow,
                        Priority = Priority.Critical,
                        DateUpdated = DateTimeOffset.UtcNow,
                        UserID = 6,
                        TType = TicketType.Bug,
                    },

                    new Ticket
                    {
                        Title = "Can't update ticket",
                        Description = "I'm logged in as admin but I can't update tickets",
                        DateCreated = DateTimeOffset.UtcNow,
                        Priority = Priority.Critical,
                        DateUpdated = DateTimeOffset.UtcNow,
                        UserID = 7,
                        TType = TicketType.Improvement,
                    },

                    new Ticket
                    {
                        Title = "Can't update ticket",
                        Description = "I'm logged in as admin but I can't update tickets",
                        DateCreated = DateTimeOffset.UtcNow,
                        Priority = Priority.Critical,
                        DateUpdated = DateTimeOffset.UtcNow,
                        UserID = 8,
                        TType = TicketType.Improvement,
                    },

                    new Ticket
                    {
                        Title = "Can't update ticket",
                        Description = "I'm logged in as admin but I can't update tickets",
                        DateCreated = DateTimeOffset.UtcNow,
                        Priority = Priority.Critical,
                        DateUpdated = DateTimeOffset.UtcNow,
                        UserID = 9,
                        TType = TicketType.Improvement,
                    },

                    new Ticket
                    {
                        Title = "Can't update ticket",
                        Description = "I'm logged in as admin but I can't update tickets",
                        DateCreated = DateTimeOffset.UtcNow,
                        Priority = Priority.Critical,
                        DateUpdated = DateTimeOffset.UtcNow,
                        UserID = 10,
                        TType = TicketType.Bug,
                    });
                context.SaveChanges();

                context.TicketsAssigned.AddRange(
                    new TicketAssigned { UserID = 8, TicketID = 1 },
                    new TicketAssigned { UserID = 7, TicketID = 2 },
                    new TicketAssigned { UserID = 6, TicketID = 3 },
                    new TicketAssigned { UserID = 5, TicketID = 4 },
                    new TicketAssigned { UserID = 4, TicketID = 5 },
                    new TicketAssigned { UserID = 3, TicketID = 6 },
                    new TicketAssigned { UserID = 2, TicketID = 7 },
                    new TicketAssigned { UserID = 1, TicketID = 8 },
                    new TicketAssigned { UserID = 5, TicketID = 9 },
                    new TicketAssigned { UserID = 3, TicketID = 10 }
                    );
                context.SaveChanges();

                //context.TicketComments.AddRange(
                //    new TicketComment { Commenter = "Caitlin Smith", TicketID = 1, CommentText = "Comment 1", CommentDate = DateTimeOffset.UtcNow },
                //    new TicketComment { Commenter = "Megan Smith", TicketID = 1, CommentText = "Comment 2", CommentDate = DateTimeOffset.UtcNow },
                //    new TicketComment { Commenter = "Carson Alexander", TicketID = 2, CommentText = "Comment 3", CommentDate = DateTimeOffset.UtcNow },
                //    new TicketComment { Commenter = "Megan Smith", TicketID = 2, CommentText = "Comment 4", CommentDate = DateTimeOffset.UtcNow },
                //    new TicketComment { Commenter = "Megan Smith", TicketID = 3, CommentText = "Comment 5", CommentDate = DateTimeOffset.UtcNow },
                //    new TicketComment { Commenter = "Caitlin Smith", TicketID = 3, CommentText = "Comment 6", CommentDate = DateTimeOffset.UtcNow },
                //    new TicketComment { Commenter = "Yan Li", TicketID = 4, CommentText = "Comment 7", CommentDate = DateTimeOffset.UtcNow },
                //    new TicketComment { Commenter = "Mark Zuckerburg", TicketID = 4, CommentText = "Comment 8", CommentDate = DateTimeOffset.UtcNow },
                //    new TicketComment { Commenter = "Mark Zuckerburg", TicketID = 5, CommentText = "Comment 9", CommentDate = DateTimeOffset.UtcNow },
                //    new TicketComment { Commenter = "Carson Alexander", TicketID = 5, CommentText = "Comment 10", CommentDate = DateTimeOffset.UtcNow },
                //    new TicketComment { Commenter = "Albert Einstein", TicketID = 6, CommentText = "Comment 11", CommentDate = DateTimeOffset.UtcNow },
                //    new TicketComment { Commenter = "Yan Li", TicketID = 6, CommentText = "Comment 12", CommentDate = DateTimeOffset.UtcNow },
                //    new TicketComment { Commenter = "Laura Norman", TicketID = 7, CommentText = "Comment 13", CommentDate = DateTimeOffset.UtcNow },
                //    new TicketComment { Commenter = "Carson Alexander", TicketID = 7, CommentText = "Comment 14", CommentDate = DateTimeOffset.UtcNow },
                //    new TicketComment { Commenter = "Nino Olivetto", TicketID = 8, CommentText = "Comment 15", CommentDate = DateTimeOffset.UtcNow },
                //    new TicketComment { Commenter = "Carson Alexander", TicketID = 8, CommentText = "Comment 16", CommentDate = DateTimeOffset.UtcNow },
                //    new TicketComment { Commenter = "Cliff Smith", TicketID = 9, CommentText = "Comment 17", CommentDate = DateTimeOffset.UtcNow },
                //    new TicketComment { Commenter = "Carson Alexander", TicketID = 9, CommentText = "Comment 18", CommentDate = DateTimeOffset.UtcNow },
                //    new TicketComment { Commenter = "Stinky McStinks", TicketID = 10, CommentText = "Comment 19", CommentDate = DateTimeOffset.UtcNow },
                //    new TicketComment { Commenter = "Caitlin Smith", TicketID = 10, CommentText = "Comment 20", CommentDate = DateTimeOffset.UtcNow }
                //    );
                //context.SaveChanges();
            }
        }
    }
}