using Microsoft.EntityFrameworkCore;
using ProductCommandMicroService.DbContexts;
using ProductCommandMicroService.Entities.Abstracts;
using ProductCommandMicroService.Repositories.Abstracts;

namespace ProductCommandMicroService.Repositories.Concretes;

public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity, new() {
    protected readonly ProductDbContext _context;

    public GenericRepository(ProductDbContext context) {
        _context = context;
    }

    public async Task<List<T>> GetAllAsync() {
        return await _context.Set<T>().ToListAsync();
    }

    public async Task<T> GetByIdAsync(int id) {
        return await _context.Set<T>().FirstOrDefaultAsync(x => x.Id == id);
    }
}
