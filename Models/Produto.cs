using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace fun_com.Models
{
  public class Produto
  {
    public int Id { get; set; }

    [Required]
    [StringLength(60, MinimumLength = 3)]
    public string Nome { get; set; }

    [Required]
    [StringLength(60, MinimumLength = 3)]
    public string Tipo { get; set; }

    [Required]
    [StringLength(60, MinimumLength = 3)]
    public string Local { get; set; }

    [Required]
    [DataType(DataType.Currency)]
    [Column(TypeName = "decimal(11, 2)")]
    public decimal Valor { get; set; }
  }
}
