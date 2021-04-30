using AulaAp.Application.ViewModels;
using System.Threading.Tasks;

namespace AulaAp.Application
{
    public interface IOrderAplication
    {
        Task AddOrder(OrderCreateViewModel orderCreateViewModel);
    }
}