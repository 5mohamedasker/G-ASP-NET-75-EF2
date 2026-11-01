using Microsoft.IdentityModel.Protocols.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Assignment02.Models
{
    [Table("EventOrganizers")]
    public class Organizer
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        [MaxLength(150)]
        public string? CompanyName { get; set; }
        public bool IsVerified { get; set; }
        [InverseProperty(nameof(OrganizerProfile.OrganizerInfo))]
        public OrganizerProfile Profile { get; set; }
        [InverseProperty(nameof(Event.Publisher))]
        public List<Event> Events { get; set; }
    }
}
