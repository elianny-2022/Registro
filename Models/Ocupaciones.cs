using System.ComponentModel.DataAnnotations;
namespace Registro.Models;
public class Ocupaciones
{
    [Key]
    public int OcupacionId {get; set;}
    public String? Descripcion { get; set; }
    public int Salario {get; set;}
}