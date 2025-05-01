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
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        [StringLength(50)]
        public int Experience { get; set; }
        [Required]
        
        public DateTime DateTime { get; set; } = DateTime.Now; //Fecha de la Visita
        public string Reason { get; set; }
        public int TotalPrice
        {
            get
            {
                int price = 0;
                if (Reason == "Vacunacion") {
                    price = 30;
                }
                if (Reason == "Revision General") {
                    price= 20;
                }
                if (Reason == "Cirugia") { 
                    price = 100;
                }
                return price;
            }
        }
        public bool NeedMed { get; set; }


    }


}

