using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SorvetesFront.Models.Validators;

namespace SorvetesFront.Models
{
    public class Estoque: Modelo<Estoque>
    {
        public string Carrinho { get; set; } = "";
        public string Sorvete { get; set; } = "";
        public int Quantidade { get; set; } = 0;

        public override void ConfigValidator(out Validator<Estoque> validator, out Estoque obj)
        {
            validator = new EstoqueValidator();
            obj = this;
        }
    }
}
