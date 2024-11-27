using YumBlazor.Entities;

namespace YumBlazor.Contracts;
public interface IOrderRepository
{
    Task<OrderHeader> CreateAsync(OrderHeader orderHeader);
    Task<IEnumerable<OrderHeader>> GetAllAsync(string? userId = null);
    Task<OrderHeader?> GetAsync(int id);
    Task<OrderHeader?> GetOrderBySessionIdAsync(string sessionId);
    Task<OrderHeader?> UpdateStatusAsync(int orderId, string status, string paymentIntentId);
}
