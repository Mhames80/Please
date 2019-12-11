using System;
using System.Collections.Generic;
using System.Text;
using BackupProject.Models;
using HailMarry.Data;
using Microsoft.EntityFrameworkCore;

namespace CheetahRacingAppTests
{
    public static class EntityExtensions
    {
        // Resets the database when ApplicationDbContext.SaveChanges() is called
        public static void Clear<T>(this DbSet<T> dbSet) where T : class
        {
            dbSet.RemoveRange(dbSet);
        }
    }

    // Class MockDb creates a mock database to use for unit testing of project
    public class MockDb
    {
        public static ApplicationDbContext CreateMockDb()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>().
                UseInMemoryDatabase(Guid.NewGuid().ToString()).Options;

            // Inserts value into the mock database
            using (var context = new ApplicationDbContext(options))
            {
                context.ContactInfo.Add(new ContactInfo { ContactInfoId = 1, FirstName = "John", LastName = "Doe", PhoneNumber = "111-111-1111" });
                context.Discussion.Add(new Discussion { DiscussionId = 1, Comment = "Testing!!!!!", ContactInfoId = 1, PostedAt = new DateTime(2019, 12, 10, 22, 16, 50, 925, DateTimeKind.Local)});
                context.RaceCars.Add(new RaceCars { RaceCarsId = 1, Make = "PORSCHE", Model = "911", Year = "2018" });
                context.Venue.Add(new Venue { VenueId = 1, Description = "Nice place", Location = "1111 County Rd 0, Neverland, ON A0A 0A0", Name = "Racing Place" });
                context.SaveChanges();
            }
            return new ApplicationDbContext(options);
        }
    }
}
