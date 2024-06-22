using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SorvetesModel;

namespace SorvetesInfra.DAOs
{
    public class CarrinhoDAO : BaseDAO<Carrinho>
    {
        public override string NomeTabela => "carrinho";

        public override Mapa[] Mapas => new Mapa[]
        {
            new() { Propriedade = "Id", Campo = "id" },
            new() { Propriedade = "Nome", Campo = "nome" },
            new() { Propriedade = "Dono", Campo = "dono" },
        };
    }
}