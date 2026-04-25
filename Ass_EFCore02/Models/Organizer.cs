using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass_EFCore02.Models
{
    public class Organizer
    {
        public int OrganizerId { get; set; }
        public string Name { get; set; }
        public string? CompanyName { get; set; }

        //Navigation Property
        public Profile Profilee { get; set; }

    }
}
