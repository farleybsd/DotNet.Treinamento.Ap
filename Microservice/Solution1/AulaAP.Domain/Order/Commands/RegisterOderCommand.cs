using AulaAp.Domain.Shared;
using AulaAP.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace AulaAP.Domain.Commands
{
    public class RegisterOderCommand : Command ,IRequest
    {
        public  List<Product> Products { get; set; }
    }
}
