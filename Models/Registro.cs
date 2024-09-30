using System.ComponentModel.DataAnnotations;

namespace SebastianSuarez_AP1_P1.Models
{
    public class Registro
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "El campo nombre es de caracter obligatorio..")]
        public string Nombre { get; set; }
    }
}
