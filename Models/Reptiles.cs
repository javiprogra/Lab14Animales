using System.ComponentModel.DataAnnotations;

namespace Lab14Animales.Models
{
    public class Reptiles: Animal
    {
        [Required]
        public string? venenosa {  get; set; }
        [Required]
        public string? longitud {  get; set; }   
    }
}
