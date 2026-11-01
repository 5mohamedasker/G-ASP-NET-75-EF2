using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Assignment02.Models
{
    public class Badge
    {
        public string BadgeNumber { get; set; }
        public DateOnly IssuedDate { get; set; }
        public string tier { get; set; }
        public int OwnerId { get; set; }
        public Attendee Owner { get; set; }
    }
}
