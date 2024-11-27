using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace YumBlazor.Entities;
public class Product
{
    public int Id { get; set; }

    [Required]
    public string? Name { get; set; }

    [Range(0.01, 1000)]
    [DisplayFormat(DataFormatString = "{0:C}")]
    [Column(TypeName = "decimal(8,2)")]
    public decimal Price { get; set; }

    public string? Description { get; set; }
    public string? SpecialTag { get; set; }
    public int CategoryId { get; set; }

    [ForeignKey("CategoryId")]
    public Category? Category { get; set; }

    public string? ImageUrl { get; set; }
}
