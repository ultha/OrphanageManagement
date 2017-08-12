using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OrphanangeSystem1.Models
{
    public class Sponsor
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ContactNo { get; set; }
        public string Address { get; set; }
        public double Amount { get; set; }

    }
    public class SponsorViewModel
    {
        public int Id { get; set; }
        [Required]
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [Required]
        [DisplayName("Last Name")]
        public string LastName { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [DisplayName("Contact Number")]
        public string ContactNo { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public double Amount { get; set; }
      


     }
}