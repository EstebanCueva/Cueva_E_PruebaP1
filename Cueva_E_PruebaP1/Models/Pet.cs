using System.ComponentModel.DataAnnotations;

namespace Cueva_E_PruebaP1.Models
{
    public class Pet
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        [StringLength(50)]
        public string PetBreed { get; set; }
        [Required]
        public int Age { get; set; }
        //Date
        public DateTime DateTime { get; set; } = DateTime.Now;
        public bool IsBreed { get; set; }//Si el perro es de raza o es mestizo
        public float Weiht { get; set; }



    }
}
