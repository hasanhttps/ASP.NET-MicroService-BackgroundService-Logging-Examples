using ProductQueryMicroService.DbContexts;
using ProductQueryMicroService.Entities.Concretes;
using ProductQueryMicroService.Repositories.Abstracts;

namespace ProductQueryMicroService.Repositories.Concretes;

public class ProductRepository : GenericRepository<Product>, IProductRepository{

    public ProductRepository(ProductDbContext context) : base(context) { 
    
    }
}
