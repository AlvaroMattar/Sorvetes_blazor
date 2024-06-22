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
    public class SorveteController : ControllerBase
    {
        public SorveteController()
        {
            dao = new SorveteDAO();
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Sorvete>>> GetAsync()
        {
            var objetos = await dao.RetornarTodosAsync();

            if (objetos == null)
                return NotFound();

            return Ok(objetos);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Sorvete>> GetId(string id)
        {
            var obj = await dao.RetornarPorIdAsync(id);

            if (obj == null)
                return NotFound();

            return obj;
        }

        [HttpPost]
        public async Task<ActionResult<Sorvete>> PostAsync(Sorvete obj)
        {
            await dao.InserirAsync(obj);

            return CreatedAtAction(
                nameof(GetId),
                new { id = obj.Id },
                obj
            );
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutAsync(string id, Sorvete obj)
        {
            if (id != obj.Id)
                return BadRequest();
        
            var objOrig = await dao.RetornarPorIdAsync(id);

            if (objOrig == null)
                return NotFound();

            objOrig.Sabor = obj.Sabor;
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
        private readonly SorveteDAO dao;
    }
}