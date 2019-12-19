using System.ComponentModel.DataAnnotations;

namespace Angular.API.DTO
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [StringLength(8, MinimumLength = 4, ErrorMessage = "You must specify password between 8 and 8 characters")]
        public string Password { get; set; }
    }
}