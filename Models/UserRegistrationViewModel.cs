using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using ThirdMVCAppDemo.DAL;

namespace ThirdMVCAppDemo.Models
{
    public class UserRegistrationViewModel
    {
        public int Id { get; set; }

        [Required]
        [EmailAddress]
        [Remote(action: "IsEmailIdValid", controller: "User")]
        public string? Email { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string? FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string? LastName { get; set; }

        public int? GenderId { get; set; }

        [Required]
        [RegularExpression(@"^(\+\d{1,2}\s?)?\(?\d{3}\)?[\s.-]?\d{3}[\s.-]?\d{4}$", ErrorMessage = "Mobile Number is not Valid")]
        [Display(Name = "Mobile")]
        public string? MobileNumber { get; set; }


        [StringLength(20, MinimumLength = 8)]
        public string? Password { get; set; }

        [Compare("Password", ErrorMessage ="Password Ans Confirm Password is Not Matched")]
        public string? ConfirmPassword { get; set; }

        public virtual Gender? Gender { get; set; }
    }
}
