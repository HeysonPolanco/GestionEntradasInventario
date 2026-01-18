using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GestionEntradasInventario.Models;
public class Entradas
{
    [Key] 
    public int EntradaId { get; set; }
    [Required(ErrorMessage = "La fecha es requerida")] 
    public DateTime Fecha { get; set; }
    [Required(ErrorMessage = "El concepto es requerido")] 
    public string Concepto { get; set; }
    [Required(ErrorMessage = "El total es requerido")]
    [Range(1, double.MaxValue, ErrorMessage = "El total debe ser mayor o igual a 1")] 
    public double Total { get; set; }

    [ForeignKey(nameof(EntradaId))] 
    public virtual ICollection<EntradasDetalle> EntradasDetalle { get; set; } = new List<EntradasDetalle>();
}
