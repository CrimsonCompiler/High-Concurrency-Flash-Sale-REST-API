using FlashSale.Api.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FlashSale.Api.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options) : IdentityDbContext<AppUser>(options)
{
    public DbSet<Product> Products { get; set; }
    public DbSet<Order> Orders { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        // Product - Indexing for performance
        builder.Entity<Product>()
            .HasIndex(p => p.IsActive);
            
        // Order - Indexing for performance
        builder.Entity<Order>()
            .HasIndex(o => o.UserId);
    }
}