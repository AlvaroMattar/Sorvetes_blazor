using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SorvetesFront.Models.Validators;

namespace SorvetesFront.Models
{
    public class Sorveteiro: Modelo<Sorveteiro>
    {
        public string Nome { get; set; } = "";
        public string Email { get; set; } = "";

        public override void ConfigValidator(out Validator<Sorveteiro> validator, out Sorveteiro obj)
        {
            validator = new SorveteiroValidator();
            obj = this;
        }
    }
}
