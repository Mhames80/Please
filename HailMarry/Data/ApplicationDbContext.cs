using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using BackupProject.Models;

namespace HailMarry.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<BackupProject.Models.ContactInfo> ContactInfo { get; set; }
        public DbSet<BackupProject.Models.Discussion> Discussion { get; set; }
        public DbSet<BackupProject.Models.RaceCars> RaceCars { get; set; }
        public DbSet<BackupProject.Models.Venue> Venue { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<ContactInfo>().HasData(
                new ContactInfo(1, "Sam", "Dean", "555-555-5555"),
                new ContactInfo(2, "Barry", "Smith", "908-908-0077")
                );
            modelBuilder.Entity<Discussion>().HasData(
             new Discussion()
             {
                 DiscussionId = 1,
                 Comment = "WE WON!!!!!",
                 ContactInfoId = 1

             },

              new Discussion()
              {
                  DiscussionId = 2,
                  Comment = "WE LOST!!!!!",
                  ContactInfoId = 2
              }

            );
            modelBuilder.Entity<Venue>().HasData(
           new Venue()
           {
               VenueId = 1,
               Name = "Canadian Tire Motorsport Park",
               Location = "3233 Concession Rd 10, Bowmanville, ON L1C 3K6",
               Description = "Canadian Tire Motorsport Park is a multi-track motorsport venue located north of Bowmanville, in Ontario, Canada, 40 miles east of Toronto"
           },

            new Venue()
            {
                VenueId = 2,
                Name = "Kawartha Downs & Speedway",
                Location = "1382 County Rd 28, Fraserville, ON K0L 1V0",
                Description = "Kawartha Speedway is a 3/8 mile paved oval located in Fraserville, Ontario, approximately 10 km southwest of Peterborough."
            }

          );
            modelBuilder.Entity<RaceCars>().HasData(
           new RaceCars()
           {
               RaceCarsId = 1,
               Make = "PORSCHE",
               Model = "911",
               Year = "2018"

           },

            new RaceCars()
            {
                RaceCarsId = 2,
                Make = "BMW",
                Model = "M2 Competition",
                Year = "2019"
            }

          );
        }
    }
}

