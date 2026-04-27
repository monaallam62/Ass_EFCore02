using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass_EFCore02.Models
{
    public class Badge
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public DateTime IssueDate { get; set; }
        public string Tier { get; set; }

        //Naviagation property
        public Attendee BadgeAtt { get; set; }

        //FK
        public int AttendeeId { get; set; }
    }
}
