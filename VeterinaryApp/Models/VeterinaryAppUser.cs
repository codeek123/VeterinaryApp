using Microsoft.AspNetCore.Identity;

namespace VeterinaryApp.Models
{
    public class VeterinaryAppUser : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
    }
}
