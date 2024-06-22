using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SorvetesModel;
using Microsoft.Data.Sqlite;
using Dapper;
using System.Text;

namespace SorvetesInfra.DAOs
{
    public class EstoqueDAO : BaseDAO<Estoque>
    {
        public override string NomeTabela => "estoque";

        public override Mapa[] Mapas => new Mapa[]
        {
            new() { Propriedade = "Id", Campo = "id" },
            new() { Propriedade = "Carrinho", Campo = "carrinho" },
            new() { Propriedade = "Sorvete", Campo = "sorvete" },
            new() { Propriedade = "Quantidade", Campo = "quantidade"},
        };
    }
}