using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;

namespace SorvetesFront.Models.Validators
{
    public class EstoqueValidator : Validator<Estoque>
    {
        public EstoqueValidator()
        {
            
        }
    }
}