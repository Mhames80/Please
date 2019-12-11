using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BackupProject.Models
{
    public class Venue
    {
        // Required added for validation
        [Key]
        public virtual int VenueId { get; set; }
        // Required added for validation
        [Required]
        public virtual string Name { get; set; }
        [Required]
        public virtual string Location { get; set; }
        [Required]
        public virtual string Description { get; set; }
    }
}
