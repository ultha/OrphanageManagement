using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OrphanangeSystem1.Models
{
    public class AdoptorRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string ZipCode { get; set; }
        public string EmailAddress { get; set; }
        public string ContactNo { get; set; }
        public string Married { get; set; }
        public DateTime DateOfMarriage { get; set; }
        public string Profession { get; set; }
        public int MonthlyIncome { get; set; }
        public string ReasonOfAdoption { get; set; }
        public bool IfAnyChild { get; set; }
        
        
    }
    public class AdoptorRequestView
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
       [Required]
       [DataType(DataType.Date)]
        public string DateOfBirth { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public string Address { get; set; }
        public string ZipCode { get; set; }
        [Required]
        [DisplayName("Email Address")]
        public string EmailAddress { get; set; }
        [Required]
        [DisplayName("Contact Number")]
        public string ContactNo { get; set; }
        [Required]
        public string Married { get; set; }
        public DateTime DateOfMarriage { get; set; }
        [Required]
        public string Profession { get; set; }
        [Required]
        [DisplayName("Monthly Income")]
        public int MonthlyIncome { get; set; }
        [Required]
        [DisplayName("Reason Of Adoption")]
        [DataType(DataType.MultilineText)]
        public string ReasonOfAdoption { get; set; }
        [Required]
        [DisplayName("Any Other Child?")]
        public bool IfAnyChild { get; set; }
        
    }
}