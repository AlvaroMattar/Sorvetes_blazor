using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SorvetesModel
{
    public class Sorvete: IModel
    {
        public string? Id { get; set; }
        public string Sabor { get; set; } = "";
        public int Quantidade { get; set; } = 0;
    }
}