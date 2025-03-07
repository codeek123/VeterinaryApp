using System.ComponentModel.DataAnnotations;

namespace VeterinaryApp.Models
{
    public class Pet : BaseEntity
    {
        [Required]
        public string Name { get; set; }
        [Range(0, 50, ErrorMessage = "Age must be between 0 and 50 years.")]
        public int Age { get; set; }
        public int OwnerId { get; set; }
       public Owner Owner { get; set; }

        public ICollection<Vaccine> Vaccines { get; set; }

    }
}
