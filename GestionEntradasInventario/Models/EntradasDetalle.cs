using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestionEntradasInventario.Models;
public class EntradasDetalle
{
    [Key] 
    public int DetalleId { get; set; }
    public int EntradaId { get; set; }
    public int ProductoId { get; set; }
    public int Cantidad { get; set; }
    public double Costo { get; set; }
}
