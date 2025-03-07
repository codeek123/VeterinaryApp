using System.ComponentModel.DataAnnotations;

namespace VeterinaryApp.Models
{
    public class Vaccine : BaseEntity
    {
        [Required]
        public string Name { get; set; }
        public ICollection<Pet> Pets { get; set; }
    }
}
