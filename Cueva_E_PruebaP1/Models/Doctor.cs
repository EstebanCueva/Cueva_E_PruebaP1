using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;
using Cueva_E_PruebaP1.Models;
namespace Cueva_E_PruebaP1.Models
{
    public class Doctor
    {
        [Key]
        [Required]
        public String Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        public int Experience { get; set; }

        [Required]
        public DateTime DateTime { get; set; } = DateTime.Now;

        [Required]
        public string Reason { get; set; }

        [Required]
        public int TotalPrice { get; set; }

        public bool NeedMed { get; set; }

        // Método para calcular el precio según el motivo
        public void CalcularPrecio()
        {
            TotalPrice = Reason switch
            {
                "Vacunacion" => 30,
                "Revision General" => 20,
                "Cirugia" => 100,
                _ => 0
            };
        }
    }
}
