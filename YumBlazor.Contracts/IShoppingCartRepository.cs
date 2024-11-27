using YumBlazor.Entities;

namespace YumBlazor.Contracts;
public interface IShoppingCartRepository
{
    Task<bool> ClearCartAsync(string? userId);
    Task<IEnumerable<ShoppingCart>> GetAllAsync(string? userId);
    Task<int> GetTotalCartCartCountAsync(string? userId);
    Task<bool> UpdateCartAsync(string userId, int productId, int updateBy);
}
