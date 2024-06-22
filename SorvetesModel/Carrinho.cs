using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SorvetesModel
{
    public class Carrinho: IModel
    {
        public string? Id { get; set; }
        public string Nome { get; set; } = "";
        public string Dono { get; set; } = "";
    }
}