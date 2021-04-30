using AulaAp.Application.ViewModels;
using AulaAP.Domain.Commands;
using AulaAP.Domain.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace AulaAp.Application.AutoMapper
{
    public  class ViewModelToDomainProfile : Profile
    {
        public ViewModelToDomainProfile()
        {
            CreateMap<OrderCreateViewModel, RegisterOderCommand>();
            CreateMap<ProductViewModel, Product>()
                .ConstructUsing(p => new Product(p.Id,p.Name,p.Value,p.Quantity));
        }
    }
}
