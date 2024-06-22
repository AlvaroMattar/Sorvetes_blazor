using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SorvetesModel
{
    public class Sorveteiro: IModel
    {
        public string? Id { get; set; }
        public string Nome { get; set; } = "";
        public string Email { get; set; } = "";
    }
}