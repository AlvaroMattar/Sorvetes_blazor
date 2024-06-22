using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SorvetesFront.Models.Validators;

namespace SorvetesFront.Models
{
    public class Carrinho: Modelo<Carrinho>
    {
        public string Nome { get; set; } = "";
        public string Dono { get; set; } = "";

        public override void ConfigValidator(out Validator<Carrinho> validator, out Carrinho obj)
        {
            validator = new CarrinhoValidator();
            obj = this;
        }
    }
}
