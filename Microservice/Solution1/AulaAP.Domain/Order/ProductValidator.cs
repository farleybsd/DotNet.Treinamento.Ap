using AulaAP.Domain.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace AulaAP.Domain.Validators
{
    public class ProDuctValidator : AbstractValidator<Product>
    {
        public ProDuctValidator()
        {
            RuleFor(o => o.Name).NotEmpty().WithMessage("O Nome do produto é obrigatorio");
            RuleFor(o => o.Value).GreaterThan(0).WithMessage("O Valor  deve ser maior que 0");
            RuleFor(o => o.Quantity).GreaterThan(0).WithMessage("A quantidade deve ser maior que 0");
        }
    }
}
