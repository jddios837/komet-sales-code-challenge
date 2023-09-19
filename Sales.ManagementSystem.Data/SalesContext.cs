using Microsoft.EntityFrameworkCore;
using Sales.ManagementSystem.Core.Models;

namespace Sales.ManagementSystem.Data;

public class SalesContext : DbContext
{
    public DbSet<User> Users { get; set; } = null!;
    public DbSet<Role> Roles { get; set; } = null!;

    public SalesContext(DbContextOptions<SalesContext> options) : base(options)
    {
        
    }
}