using System.ComponentModel.DataAnnotations;

namespace Sales.ManagementSystem.Core.Models;

public class User
{
    [Key]
    public int UserId { get; set; }
    public string DisplayName { get; set; } = null!;
    public string UserName { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string Password { get; set; } = null!;
    public DateTime CreatedDate { get; set; } 
    public virtual Role Role { get; set; } = null!;
}