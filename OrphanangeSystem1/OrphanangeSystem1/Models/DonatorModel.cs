using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OrphanangeSystem1.Models
{
    public class Donator
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string ContactNo { get; set; }
        public string Email { get; set; }
        public string DonatingAmount { get; set; }
        public string FeildToSpend { get; set; }

    }
    public class DonatorViewModel
    {
        public int Id { get; set; }
        [Required]
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [Required]
        [DisplayName("Middle Name")]
        public string MiddleName { get; set; }
        [Required]
        [DisplayName("Last Name")]
        public string LastName { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        [DisplayName("Contact Number")]
        public string ContactNo{ get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        [DisplayName("Donation Amount")]

        public string DonatingAmount { get; set; }
        [Required]
        [DisplayName("Field To Spend")]
        public string FeildToSpend { get; set; }



    }
}