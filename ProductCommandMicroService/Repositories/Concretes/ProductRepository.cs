using ProductCommandMicroService.DbContexts;
using ProductCommandMicroService.Entities.Concretes;
using ProductCommandMicroService.Repositories.Abstracts;

namespace ProductCommandMicroService.Repositories.Concretes;

public class ProductRepository : GenericRepository<Product>, IProductRepository{

    public ProductRepository(ProductDbContext context) : base(context) { 
    
    }
}
