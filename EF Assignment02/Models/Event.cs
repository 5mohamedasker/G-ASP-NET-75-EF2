using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Assignment02.Models
{
    public class Event
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateOnly StertDate { get; set; }
        public DateOnly EndDate { get; set; }
        public int MaxAttendees { get; set; }
        public int PublisherId { get; set; }
        [InverseProperty(nameof(Organizer.Events))]
        public Organizer Publisher { get; set; }
    }
}
