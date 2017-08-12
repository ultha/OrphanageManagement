using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OrphanangeSystem1.Models
{
    public class Orphan
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public bool Disable { get; set; }
        public DateTime JoinedDate { get; set; }
        public DateTime? LeaveDate { get; set; }

    }
    public class OrphanViewModel
    {

        public int Id { get; set; }
        [Required]
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [Required]
        [DisplayName("Last Name")]
        public string LastName { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public bool Disable { get; set; }
        [Required]

        public DateTime JoinedDate { get; set; }
        public DateTime? LeaveDate { get; set; }


    }
}