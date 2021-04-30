using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace AulaAp.Application.Ioc
{
    public static class AplicationDepedencies
    {
        public static void RegsiterAplicationDepedencies(this IServiceCollection service) =>
            service.AddScoped<IOrderAplication, OrderAplication>();
    }
}
