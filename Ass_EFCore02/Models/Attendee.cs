using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass_EFCore02.Models
{
    public class Attendee
    {
        public int AttendeeId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }

        public string Street { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }

        //Navigation property
        public Badge? AttBadge { get; set; }
    }
}
