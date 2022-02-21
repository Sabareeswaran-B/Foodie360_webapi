using System.ComponentModel.DataAnnotations;

namespace Foodie360.Models
{
    public class UserLogins
    {
        [Required]
        public string? PhoneNo { get; set; }

        [Required]
        public string? Password { get; set; }

        public UserLogins() { }
    }
}
