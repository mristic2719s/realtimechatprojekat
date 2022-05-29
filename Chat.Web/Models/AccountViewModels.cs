using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Chat.Web.Models
{
    public class LoginViewModel
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Lozinka")]
        public string Password { get; set; }

        [Display(Name = "Zapamti me?")]
        public bool RememberMe { get; set; }
    }

    public class RegisterViewModel
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string DisplayName { get; set; }

        public string Avatar { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Lozinka mora biti najmanje {2} karaktera duga.", MinimumLength = 3)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "Lozinka i potvrdna lozinka se ne poklapaju.")]
        public string ConfirmPassword { get; set; }
    }
}
