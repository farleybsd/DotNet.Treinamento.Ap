using AulaAp.Application.ViewModels;
using AulaAP.Domain.Commands;
using AutoMapper;
using MediatR;
using System;
using System.Threading.Tasks;

namespace AulaAp.Application
{
    public class OrderAplication : IOrderAplication
    {
        private readonly IMapper mapper;
        private readonly IMediator mediator;
        public OrderAplication(IMapper mapper, IMediator mediator)
        {
            this.mapper = mapper;
            this.mediator = mediator;
        }

        public async Task AddOrder(OrderCreateViewModel orderCreateViewModel)
        {
            RegisterOderCommand command = mapper.Map<OrderCreateViewModel, RegisterOderCommand>(orderCreateViewModel);
            await mediator.Send(command);
        }
    }
}
