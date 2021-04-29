using AulaAP.Domain.Commands;
using AulaAP.Domain.Entities;
using AulaAP.Domain.Events;
using AulaAP.Domain.Interfaces;
using MediatR;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace AulaAP.Domain.Services
{
    public class OrderCommandHandler : IRequestHandler<RegisterOderCommand>
    {
        private IOrderRepository repository;

        public OrderCommandHandler(IOrderRepository repository)
        {
            this.repository = repository;
        }

        public async Task<Unit> Handle(RegisterOderCommand request, CancellationToken cancellationToken)
        {
            var order = new Order(Order.GenerateOrderCode(), request.Products.ToList());

            if (!order.IsValid())
            {
                throw new Exception("O pedido é inválido");
            }

            if ((await repository.FindByOrderCode(order.OrderCode)) != null)
            {
                throw new Exception("O pedido já existe  no banco de dados");
            }

            await repository.Add(order);

            var result = new RegisterOrderSuccesEvent(order.OrderCode);

            return Unit.Value;
        }
    }
}
