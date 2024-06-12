using ProductCommandMicroService.Entities.Abstracts;

namespace ProductCommandMicroService.Repositories.Abstracts;

public interface IGenericRepository<T> where T : BaseEntity, new() {
    Task<List<T>> GetAllAsync();
    Task<T> GetByIdAsync(int id);
}
