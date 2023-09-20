using System.ComponentModel.DataAnnotations;

namespace Sales.ManagementSystem.Core.Models;

public class ProductCategory
{
    [Key]
    public int Id { get; set; }
    
    [Required]
    [StringLength(100)]
    public string Description { get; set; } = null!;
    
    public int? Code { get; set; }
}