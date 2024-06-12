using ProductQueryMicroService.Entities.Abstracts;

namespace ProductQueryMicroService.Repositories.Abstracts;

public interface IGenericRepository<T> where T : BaseEntity, new() {
    Task AddAsync(T entity);
    Task Update(T entity);
    Task DeleteAsync(int id);
    Task SaveChanges();
}
