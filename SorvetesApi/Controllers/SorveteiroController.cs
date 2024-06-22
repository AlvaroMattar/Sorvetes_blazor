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
    public class SorveteiroController : ControllerBase
    {
        public SorveteiroController()
        {
            dao = new SorveteiroDAO();
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Sorveteiro>>> GetAsync()
        {
            var objetos = await dao.RetornarTodosAsync();

            if (objetos == null)
                return NotFound();

            return Ok(objetos);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Sorveteiro>> GetId(string id)
        {
            var obj = await dao.RetornarPorIdAsync(id);

            if (obj == null)
                return NotFound();

            return obj;
        }

        [HttpPost]
        public async Task<ActionResult<Sorveteiro>> PostAsync(Sorveteiro obj)
        {
            await dao.InserirAsync(obj);

            return CreatedAtAction(
                nameof(GetId),
                new { id = obj.Id },
                obj
            );
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutAsync(string id, Sorveteiro obj)
        {
            if (id != obj.Id)
                return BadRequest();
        
            var objOrig = await dao.RetornarPorIdAsync(id);

            if (objOrig == null)
                return NotFound();

            objOrig.Nome = obj.Nome;
            objOrig.Email = obj.Email;

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
        private readonly SorveteiroDAO dao;
    }
}