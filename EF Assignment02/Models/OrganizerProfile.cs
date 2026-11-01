using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Assignment02.Models
{
    public class OrganizerProfile
    {
        public int Id { get; set; }
        public string Biography { get; set; }
        public string Website { get; set; }
        public string Logo { get; set; }
        public int OrganizerInfoId { get; set; }
        [InverseProperty(nameof(Organizer.Profile))]
        public Organizer OrganizerInfo { get; set; }
    }
}