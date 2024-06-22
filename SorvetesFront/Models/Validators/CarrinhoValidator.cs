using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;

namespace SorvetesFront.Models.Validators
{
    public class CarrinhoValidator : Validator<Carrinho>
    {
        public CarrinhoValidator()
        {
            AddRule(p => p.Nome).NotEmpty().NotNull().WithMessage("O nome não pode ser nulo ou vazio.");
            AddRule(p => p.Nome).MinimumLength(3).WithMessage("O nome deve ter no mínimo 3 caracteres");
            AddRule(p => p.Nome).MaximumLength(100).WithMessage("O nome deve ter no máximo 100 caracteres");
        }
    }
}