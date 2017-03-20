using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DenimSACCOS.Models
{
    public class Contact
    {
        [Required(ErrorMessage = "Enter You Name")]
        public string Name { get; set; }
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }
        [Range(1, 100)]
        public int Phone { get; set; }
        [Required(ErrorMessage = "Field can't be empty")]
        public string Message { get; set; }
    }

}