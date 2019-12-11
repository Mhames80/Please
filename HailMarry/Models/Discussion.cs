using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BackupProject.Models
{
    public class Discussion
    {
        //set primary key
        [Key]
        public virtual int DiscussionId { get; set; }
        // Required added for validation
        [Required]
        public virtual string Comment { get; set; }
        // this is so date will auto post to comment
        public virtual DateTime PostedAt { get; set; } = DateTime.Now;
        //grab name from contactinfo
        public virtual int ContactInfoId { get; set; }
        public virtual ContactInfo DiscussionContactInfo { get; set; }
    }
}
