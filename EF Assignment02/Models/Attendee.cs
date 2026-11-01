using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace EF_Assignment02.Models
{
    public class Attendee
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(150)]
        public string FullName { get; set; }
        [Required]
        [MaxLength(200)]
        public string Email { get; set; }
        [Required]
        [MaxLength(150)]
        public string Street { get; set; }
        [Required]
        [MaxLength(100)]
        public string City { get; set; }
        [Required]
        [MaxLength(100)]
        public string Country { get; set; }
        [Column("ZipCode")]
        [Required]
        [MaxLength(20)]
        public string PostalCode { get; set; }
        [NotMapped]
        public string FullAddress { get { return $"{Street} {City} {Country} {PostalCode}"; } }

        public Badge AttendeeBadge { get; set; }

    }
}
