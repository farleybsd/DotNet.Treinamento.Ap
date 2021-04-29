using AulaAP.Domain.Commands;
using AulaAP.Domain.Interfaces;
using AulaAP.Domain.Services;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace AulaAP.Domain.Ioc
{
    public static class DomainDependencies
    {
        public static void RegisterDomainDependencies(this IServiceCollection service) =>
            service
            .AddMediatR(typeof(RegisterOderCommand).GetTypeInfo().Assembly)
            .AddScoped<IRequestHandler<RegisterOderCommand>,OrderCommandHandler>();
        
    }
}
