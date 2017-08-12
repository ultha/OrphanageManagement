using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrphanangeSystem1.Models
{
    public class Volunteer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EventToGetInvolved { get; set; }
        public DateTime Date { get; set; }
        public bool EmailNotification { get; set; }

    }
}