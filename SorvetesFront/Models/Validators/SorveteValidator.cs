using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;

namespace SorvetesFront.Models.Validators
{
    public class SorveteValidator : Validator<Sorvete>
    {
        public SorveteValidator()
        {
            AddRule(p => p.Sabor).NotEmpty().NotNull().WithMessage("O sabor não inserido.");
            AddRule(p => p.Sabor).MinimumLength(2).WithMessage("O sabor tem que ter mais que 2 caracteres.");
            AddRule(p => p.Sabor).MaximumLength(20).WithMessage("O sabor não deve ter mais que 20 caracteres.");
            AddRule(p => p.Quantidade).GreaterThanOrEqualTo(0).LessThanOrEqualTo(100).WithMessage("O limite é de 0 e 100 unidades.");
        }
    }
}