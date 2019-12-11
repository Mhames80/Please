using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BackupProject.Models
{
    public class Venue
    {
        [Key]
        public virtual int VenueId { get; set; }
        [Required]
        public virtual string Name { get; set; }
        [Required]
        public virtual string Location { get; set; }
        [Required]
        public virtual string Description { get; set; }
    }
}
