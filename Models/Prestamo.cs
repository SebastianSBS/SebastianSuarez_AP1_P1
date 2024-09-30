using System.ComponentModel.DataAnnotations;

namespace SebastianSuarez_AP1_P1.Models
{
    public class Prestamo
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "El campo nombre es de caracter obligatorio..")]
        public string Nombres { get; set; }
        [Required(ErrorMessage = "El campo concepto es de caracter obligatorio..")]
        public string Concepto { get; set; }
        [Required(ErrorMessage = "El campo monto es de caracter obligatorio..")]
        public int Monto { get; set; }
    }
}
