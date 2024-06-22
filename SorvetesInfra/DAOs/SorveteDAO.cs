using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SorvetesModel;

namespace SorvetesInfra.DAOs
{
    public class SorveteDAO : BaseDAO<Sorvete>
    {
        public override string NomeTabela => "sorvete";

        public override Mapa[] Mapas => new Mapa[]
        {
            new() { Propriedade = "Id", Campo = "id" },
            new() { Propriedade = "Sabor", Campo = "sabor" },
            new() { Propriedade = "Quantidade", Campo = "quantidade" },
        };
    }
}