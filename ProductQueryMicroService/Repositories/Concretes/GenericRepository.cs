using Microsoft.EntityFrameworkCore;
using ProductQueryMicroService.DbContexts;
using ProductQueryMicroService.Entities.Abstracts;
using ProductQueryMicroService.Repositories.Abstracts;

namespace ProductQueryMicroService.Repositories.Concretes;

public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity, new() {
    protected readonly ProductDbContext _context;

    public GenericRepository(ProductDbContext context) {
        _context = context;
    }

    public async Task AddAsync(T entity) {
        await _context.Set<T>().AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id) {
        var entity = await _context.Set<T>().FirstOrDefaultAsync(x => x.Id == id);
        _context.Set<T>().Remove(entity!);
        await _context.SaveChangesAsync();
    }

    public async Task Update(T entity) {
        _context.Set<T>().Update(entity);
        await _context.SaveChangesAsync();
    }

    public async Task SaveChanges() {
        await _context.SaveChangesAsync();
    }
}
