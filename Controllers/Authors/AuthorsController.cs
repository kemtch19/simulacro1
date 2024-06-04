using Microsoft.AspNetCore.Mvc;
using Simulacro1.Models;
using Simulacro1.Services;

namespace Simulacro1.AddControllers
{
    [ApiController]
    [Route("api/[Controller]")]

    public class AuthorsController : ControllerBase
    {
        private readonly IAuthorRepository _authorRepository;

        public AuthorsController(IAuthorRepository authorRepository)
        {
            _authorRepository = authorRepository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Author>> GetAuthors()
        {
            try
            {
                return Ok(_authorRepository.GetAll());
            }
            catch (Exception e)
            {
                return StatusCode(500, $"Error para los autores: {e.Message}");
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetAuthor(int id)
        {
            try
            {
                var author = _authorRepository.GetOne(id);

                if (author == null)
                {
                    return NotFound($"No se encontro el autor con el id: {id}");
                }

                return Ok(author);
            }
            catch (Exception e)
            {
                return StatusCode(500, $"Error, autor no se encontro: {e.Message}");
            }
        }
    }
}