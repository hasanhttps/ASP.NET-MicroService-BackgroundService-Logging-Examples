using Microsoft.EntityFrameworkCore;
using ProductCommandMicroService.Entities.Concretes;

namespace ProductCommandMicroService.DbContexts;

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
