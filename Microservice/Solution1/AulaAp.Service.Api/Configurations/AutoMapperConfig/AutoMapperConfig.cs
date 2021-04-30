using AulaAp.Application.AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AulaAp.Service.Api.Configurations.AutoMapperConfig
{
    public static class AutoMapperConfig
    {
        public static void AddAutoMapperConfig(this IServiceCollection service) =>
            service.AddAutoMapper(typeof(DomainToViewModel),typeof(ViewModelToDomainProfile));
    }
}
