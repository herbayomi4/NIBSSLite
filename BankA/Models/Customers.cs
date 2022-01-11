using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BankA.Models
{
    public class Customers
    {
        public int customerId { get; set; }

        [Required]
        [Display(Name = "First Name")]
        [StringLength(50, ErrorMessage = "First Name length can't be more than 50.")]
        public string firstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        [StringLength(50, ErrorMessage = "Last Name length can't be more than 50.")]
        public string lastName { get; set; }

        [EmailAddress]
        [Display(Name = "Email Address")]
        [Remote("VerifyEmail", "Home")]
        public string email { get; set; }

        [Required, DataType(DataType.PhoneNumber)]
        [Display(Name = "Phone Contact")]
        [StringLength(11, ErrorMessage = "Contact can't be more than 11 digits.")]
        public string contact { get; set; }

        [Required, Display(Name = "Delivery Address")]
        [StringLength(50, ErrorMessage = "Delivery Address length can't be more than 50.")]
        public string address { get; set; }

        [Required, Display(Name = "City")]
        [StringLength(50, ErrorMessage = "City Name length can't be more than 50.")]
        public string city { get; set; }

    }
}
