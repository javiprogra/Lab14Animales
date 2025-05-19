using System.ComponentModel.DataAnnotations;

namespace Lab14Animales.Models
{
    public class Animal
    {
        [Required]
        public string? nombre { get; set; }
        [Required]
        public string? especie { get; set; }
        [Required]
        public string? tipoAlimentacion { get; set; }
        [Required]
        public string? tiempoVida {  get; set; }

    }
}
