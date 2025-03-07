using System.ComponentModel.DataAnnotations;

namespace VeterinaryApp.Models
{
    public class Owner
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Surname { get; set; }

        [Range(18, 100, ErrorMessage = "Age must be between 18 and 100.")]
        public int Age { get; set; }

      //  public ICollection<Pet> Pets { get; set; } 
        
        public string GetFullName() => $"{Name} {Surname}";
    }
}
