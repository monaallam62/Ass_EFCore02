using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass_EFCore02.Models
{
    public class Profile
    {
        public int ProfileId { get; set; }
        public string Bio { get; set; } 
        public string Website { get; set; }
        public string Logo { get; set; }

        //Navigation Property 
        public Organizer Organizer{ get; set; }

        //FK
        public int OrganizerId { get; set; }
    }
}
