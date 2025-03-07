using System.ComponentModel.DataAnnotations;

namespace VeterinaryApp.Models
{
    public class BaseEntity
    {
        [Key]
        public Guid Id { get; set; }
    }
}
