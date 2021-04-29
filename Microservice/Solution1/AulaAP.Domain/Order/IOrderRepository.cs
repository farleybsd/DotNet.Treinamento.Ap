using AulaAP.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AulaAP.Domain.Interfaces
{
    public interface IOrderRepository
    {
        Task<IEnumerable<Order>> GetAll();
        Task Add(Order order);
        Task<Order> FindByOrderCode( string orderCode);
    }
}