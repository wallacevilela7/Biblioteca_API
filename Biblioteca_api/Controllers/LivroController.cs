using Asp.Versioning;
using Biblioteca_api.Business;
using Biblioteca_api.Model;
using Microsoft.AspNetCore.Mvc;

namespace Biblioteca_api.Controllers
{
    [ApiVersion("1.0")]
    [ApiController]
    [Route("api/[controller]/v{version:apiVersion}")]
    public class LivroController : ControllerBase
    {
        private ILivroBusiness _business;

        public LivroController(ILivroBusiness business)
        {
            _business = business;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_business.FindAll());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var livro = _business.FindById(id);

            if (livro == null) return NotFound();

            return Ok(livro);  
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _business.Delete(id);
            return NoContent();
        }

        [HttpPost]
        public IActionResult Post([FromBody] Livro livro)
        {
            if (livro == null) return BadRequest();

            return Ok(_business.Create(livro));
        }

        [HttpPut]
        public IActionResult Put([FromBody] Livro livro)
        {
            if (livro == null) return BadRequest();

            return Ok(_business.Update(livro));
        }
    }
}
