using YumBlazor.Entities;

namespace YumBlazor.Contracts;
public interface IProductRepository
{
    Task<Product> CreateAsync(Product obj);
    Task<bool> DeleteAsync(int id);
    Task<IEnumerable<Product>> GetAllAsync();
    Task<Product> GetAsync(int id);
    Task<Product> UpdateAsync(Product obj);
}
