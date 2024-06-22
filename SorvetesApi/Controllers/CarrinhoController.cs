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
    public class CarrinhoController : ControllerBase
    {
        public CarrinhoController()
        {
            dao = new CarrinhoDAO();
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Carrinho>>> GetAsync()
        {
            var objetos = await dao.RetornarTodosAsync();

            if (objetos == null)
                return NotFound();

            return Ok(objetos);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Carrinho>> GetId(string id)
        {
            var obj = await dao.RetornarPorIdAsync(id);

            if (obj == null)
                return NotFound();

            return obj;
        }

        [HttpPost]
        public async Task<ActionResult<Carrinho>> PostAsync(Carrinho obj)
        {
            await dao.InserirAsync(obj);

            return CreatedAtAction(
                nameof(GetId),
                new { id = obj.Id },
                obj
            );
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutAsync(string id, Carrinho obj)
        {
            if (id != obj.Id)
                return BadRequest();
        
            var objOrig = await dao.RetornarPorIdAsync(id);

            if (objOrig == null)
                return NotFound();

            objOrig.Nome = obj.Nome;
            objOrig.Dono = obj.Dono;

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
        private readonly CarrinhoDAO dao;
    }
}