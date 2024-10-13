using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SebastianSuarez_AP1_P1.Models
{
    public class Cobros
    {
        [Key]
        public int CobroId { get; set; }
        public DateTime Fecha {  get; set; }
        [ForeignKey("PrestamoId")]
        public int DeudorId { get; set; }
        public int Monto { get; set; }
        [ForeignKey("CobrosId")]
        public ICollection<CobrosDetalle>CobrosDetalles { get; set; } = new List<CobrosDetalle>();
    }

    public class CobrosDetalle
    {
        [Key]
        public int DetalleId { get; set; }
        public int CobroId { get; set; }    
        public int PrestamoId { get; set; }
        public int ValorCobrado { get; set; }

    }
}
