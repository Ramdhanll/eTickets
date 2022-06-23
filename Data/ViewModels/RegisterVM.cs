using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.ViewModels
{
   public class RegisterVM
   {
      [Display(Name = "Full name")]
      [Required(ErrorMessage = "Full name is required")]
      public string FullName { get; set; }

      [Display(Name = "Email address")]
      [Required(ErrorMessage = "Email address is required")]
      public string EmailAddress { get; set; }

      [Required]
      [DataType(DataType.Password)]
      [MinLength(5)]
      public string Password { get; set; }

      [Display(Name = "Confirm password")]
      [Required(ErrorMessage = "Confirm password is required")]
      [DataType(DataType.Password)]
      [Compare("Password", ErrorMessage = "Password do not match")]
      public string ConfirmPassword { get; set; }
   }
}