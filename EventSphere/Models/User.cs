using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace EventSphere.Models
{
    public class User : IdentityUser
    {

        [Required]
        public int Id { get; set; }
        
        [Required]
        public string Username { get; set; } = string.Empty;

        [Required]
        public string Password { get; set; } = string.Empty ;

        [Required]
        public string Name { get; set; } = string.Empty;
        
        [Required]
        public string Surname { get; set; } = string.Empty;
        
        [Required]
        public string Email { get; set; } = string.Empty;
        
        [Required]
        public bool isOrganizer { get; set; } = false;

        [Required]
        public string PhoneNumber { get; set; } = string.Empty;


    }
}
