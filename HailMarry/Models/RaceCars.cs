using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BackupProject.Models
{
    public class RaceCars
    {
        [Key]
        public virtual int RaceCarsId { get; set; }
        [Required]
        public virtual string Make { get; set; }
        [Required]
        public virtual string Model { get; set; }
        [Required]
        public virtual string Year { get; set; }
        public virtual string Photo { get; set; }
    }
}
