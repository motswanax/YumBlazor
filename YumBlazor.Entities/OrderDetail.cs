using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YumBlazor.Entities;
public class OrderDetail
{
    public int Id { get; set; }

    public int OrderHeaderId { get; set; }
    public OrderHeader? OrderHeader { get; set; }

    public int ProductId { get; set; }
    public Product? Product { get; set; }

    [Required]
    public int Count { get; set; }

    [Required]
    [DisplayFormat(DataFormatString = "{0:C}")]
    [Column(TypeName = "decimal(8,2)")]
    public decimal Price { get; set; }

    [Required]
    public required string ProductName { get; set; }
}
