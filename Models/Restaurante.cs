using System.ComponentModel.DataAnnotations;

namespace laboratorio.Models
{
    public class Restaurante
    {
        public int Id { get; set; }

        [Display(Name="Nombre")]
        [Required, MaxLength(80)]
        public string Nombre { get; set; }
        public TipoCocina Cocina{ get; set; }
    }
}   