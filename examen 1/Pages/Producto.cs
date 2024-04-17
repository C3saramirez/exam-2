using System.ComponentModel.DataAnnotations;
public class Producto
{
    [Required(ErrorMessage = "NO DEBE ESTAR VACIO")]
    public string? Nombre { get; set; }
    [Required(ErrorMessage = "NO DEBE ESTAR VACIO")]

    [Range(1, int.MaxValue, ErrorMessage = "DEBE ESER MAYOR A 0")]
    public int Id { get; set; }
    [Required(ErrorMessage = "SELECCIONA UN DEPARTAMENTO")]
    public string? Departamento { get; set; }
}