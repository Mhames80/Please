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
    }
}
