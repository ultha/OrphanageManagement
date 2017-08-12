using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrphanangeSystem1.Models
{
    public class Supervisor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ContactNo { get; set; }
        public int NumberofOrphan { get; set; }
        public string Address { get; set; }
    }
}