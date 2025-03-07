using Microsoft.AspNetCore.Identity;

namespace VeterinaryApp.Models
{

    public class VeterinaryApplicationUser : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
    }
}
