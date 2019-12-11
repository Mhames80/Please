using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BackupProject.Models
{
    public class Discussion
    {
        [Key]
        public virtual int DiscussionId { get; set; }
        [Required]
        public virtual string Comment { get; set; }

        public virtual DateTime PostedAt { get; set; } = DateTime.Now;
        public virtual int ContactInfoId { get; set; }

        public virtual ContactInfo DiscussionContactInfo { get; set; }
    }
}
