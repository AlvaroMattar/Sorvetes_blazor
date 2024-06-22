using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SorvetesModel
{
    public class Estoque: IModel
    {
        public string? Id { get; set; }
        public string Carrinho { get; set; } = "";
        public string Sorvete { get; set; } = "";
        public int Quantidade { get; set; } = 0;
    }
}