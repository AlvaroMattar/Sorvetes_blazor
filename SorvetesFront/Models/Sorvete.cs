using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SorvetesFront.Models.Validators;

namespace SorvetesFront.Models
{
    public class Sorvete : Modelo<Sorvete>
    {
        public string Sabor { get; set; } = "";
        public int Quantidade { get; set; } = 0;

        public override void ConfigValidator(out Validator<Sorvete> validator, out Sorvete obj)
        {
            validator = new SorveteValidator();
            obj = this;
        }
    }
}