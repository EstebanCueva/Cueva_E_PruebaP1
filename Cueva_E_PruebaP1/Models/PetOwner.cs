using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cueva_E_PruebaP1.Models
{
    public class PetOwner
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public DateTime DateTime { get; set; } = DateTime.Now;
        public bool Pets { get; set; } //Si la persona tiene mas de una mascota, Si o no 
        public float budget { get; set; }
        public int IdPet { get; set; }
        [ForeignKey("IdPet")]
        public Pet? Pet { get; set; }
        public int IdDoctor { get; set; }
        [ForeignKey("IdDoctor")]
        public Doctor Doctor { get; set; }




    }
}

