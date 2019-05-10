using System.ComponentModel.DataAnnotations;

namespace TPCoinApp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [StringLength(18, MinimumLength = 6, ErrorMessage = "You must specify a password between 6 and 18 characters")]
        public string Password { get; set; }
    }
}