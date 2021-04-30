using AulaAp.Application.ViewModels;
using AulaAP.Domain.Commands;
using AulaAP.Domain.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace AulaAp.Application.AutoMapper
{
    public class DomainToViewModel : Profile
    {
        public DomainToViewModel()
        {
            CreateMap<Product, ProductViewModel>();
            CreateMap<RegisterOderCommand, OrderCreateViewModel>();
        }
    }
}
