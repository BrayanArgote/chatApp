using System.ComponentModel.DataAnnotations;

namespace Application.DTOs
{
    public class RegisterUserDto
    {
        [Required]
        [StringLength(30, MinimumLength = 5)]
        public string Username { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 8)]
        public string Password { get; set; }

        [Required]
        [Range(18, 100)]
        public int Age { get; set; }

        [Required]
        [EmailAddress]
        [StringLength(100, MinimumLength = 10)]
        public string Email {  get; set; }
    }
}
