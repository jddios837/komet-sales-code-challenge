using System.ComponentModel.DataAnnotations;

namespace Sales.ManagementSystem.Core.Models;

public class Product
{
    [Key]
    public int Id { get; set; }
    
    [Required]
    [StringLength(200)]
    public string Name { get; set; } = null!;
    
    [StringLength(5000)]
    public string Description { get; set; } = null!;
    
    public int? Code { get; set; }

    public virtual ProductCategory Category { get; set; } = null!;
}