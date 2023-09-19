using System.ComponentModel.DataAnnotations;

namespace Sales.ManagementSystem.Core.Models;

public class Role
{
    public int RoleId { get; set; }
    
    [Required]
    [StringLength(100)]
    public string Name { get; set; } = null!;

    [Required]
    [StringLength(1000)]
    public string Description { get; set; } = null!;
}