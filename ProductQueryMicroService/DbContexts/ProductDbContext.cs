using Microsoft.EntityFrameworkCore;
using ProductQueryMicroService.Entities.Concretes;

namespace ProductQueryMicroService.DbContexts;

public class ProductDbContext : DbContext {

    // Constructor

    public ProductDbContext(DbContextOptions<ProductDbContext> options) 
        : base(options) {

    }

    // Models

    protected override void OnModelCreating(ModelBuilder modelBuilder) {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ProductDbContext).Assembly);
        base.OnModelCreating(modelBuilder);
    }

    // Tables

    public virtual DbSet<Product> Products { get; set; }
}
