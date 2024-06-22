using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SorvetesModel;

namespace SorvetesInfra.DAOs
{
    public class SorveteiroDAO : BaseDAO<Sorveteiro>
    {
        public override string NomeTabela => "sorveteiro";

        public override Mapa[] Mapas => new Mapa[]
        {
            new() { Propriedade = "Id", Campo = "id" },
            new() { Propriedade = "Nome", Campo = "nome" },
            new() { Propriedade = "Email", Campo = "email" }
        };
    }
}