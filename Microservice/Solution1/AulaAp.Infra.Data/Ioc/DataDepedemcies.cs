using AulaAP.Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace AulaAp.Infra.Data.Ioc
{
    public static class DataDepedemcies
    {
        public static void RegisterDataDepedemcies(this IServiceCollection service) =>
            service.AddScoped<IOrderRepository, OrderRepository>();
    }
}
