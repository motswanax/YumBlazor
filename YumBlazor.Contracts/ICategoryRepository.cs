using YumBlazor.Entities;

namespace YumBlazor.Contracts;

public interface ICategoryRepository
{
    Task<Category> CreateAsync(Category obj);
    Task<bool> DeleteAsync(int id);
    Task<IEnumerable<Category>> GetAllAsync();
    Task<Category> GetAsync(int id);
    Task<Category> UpdateAsync(Category obj);
}
