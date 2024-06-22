using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SorvetesModel;
using SorvetesInfra.DAOs;
using Microsoft.AspNetCore.Mvc;

namespace SorvetesApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EstoqueController : ControllerBase
    {
        public EstoqueController()
        {
            dao = new EstoqueDAO();
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Estoque>>> GetAsync()
        {
            var objetos = await dao.RetornarTodosAsync();

            if (objetos == null)
                return NotFound();

            return Ok(objetos);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Estoque>> GetId(string id)
        {
            var obj = await dao.RetornarPorIdAsync(id);

            if (obj == null)
                return NotFound();

            return obj;
        }

        [HttpPost]
        public async Task<ActionResult<Estoque>> PostAsync(Estoque obj)
        {
            await dao.InserirAsync(obj);

            return CreatedAtAction(
                nameof(GetId),
                new { id = obj.Id },
                obj
            );
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutAsync(string id, Estoque obj)
        {
            if (id != obj.Id)
                return BadRequest();
        
            var objOrig = await dao.RetornarPorIdAsync(id);

            if (objOrig == null)
                return NotFound();

            objOrig.Carrinho = obj.Carrinho;
            objOrig.Sorvete = obj.Sorvete;
            objOrig.Quantidade = obj.Quantidade;

            await dao.AlterarAsync(obj);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(string id)
        {
            var obj = await dao.RetornarPorIdAsync(id);
        
            if (obj == null)
                return NotFound();
        
            await dao.ExcluirAsync(id);

            return NoContent();
        }
        private readonly EstoqueDAO dao;
    }
}