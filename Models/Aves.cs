using System.ComponentModel.DataAnnotations;

namespace Lab14Animales.Models
{
    public class Aves: Animal
    {
        [Required]
        public string? vuela {  get; set; }
        [Required]
        public string? periodoIncubacion { get; set; }
    }
}
