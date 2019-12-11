using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BackupProject.Models
{
    public class ContactInfo
    {
        public ContactInfo() { }        
        public ContactInfo(int ContactInfoId, String FirstName, String LastName, String PhoneNumber)
        {
            this.ContactInfoId = ContactInfoId;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.PhoneNumber = PhoneNumber;
        }
        //set primary key
        [Key]
        public virtual int ContactInfoId { get; set; }
        // Required added for validation
        [Required]
        public virtual String FirstName { get; set; }
        [Required]
        public virtual String LastName { get; set; }
        [Required]
        public virtual String PhoneNumber { get; set; }        
        public virtual List<Discussion> Discussions { get; set; }

    }
}
