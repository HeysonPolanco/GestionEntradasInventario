using System.ComponentModel.DataAnnotations;

namespace GestionEntradasInventario.Models;
public class Productos
{
    [Key] 
    public int ProductoId { get; set; }

    [Required(ErrorMessage = "La descripción es requerida")] 
    public string Descripcion { get; set; }

    [Required(ErrorMessage = "El costo es requerido")]
    [Range(1, double.MaxValue, ErrorMessage = "El costo debe ser mayor o igual a 1")] 
    public double Costo { get; set; }

    [Required(ErrorMessage = "El precio es requerido")]
    [Range(1, double.MaxValue, ErrorMessage = "El precio debe ser mayor o igual a 1")] 
    public double Precio { get; set; }
    public int Existencia { get; set; } = 0;
}
