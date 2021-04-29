using AulaAP.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AulaAP.Domain.Services
{
    public interface IOrderRepository
    {
        Task<IEnumerable<Order>> GetAll();
        Task Add(Order order);
        Task<Order> FindByOrderCode( int orderCode);
    }
}