using Microsoft.AspNetCore.Mvc;
using Simulacro1.Models;
using Simulacro1.Services;

namespace Simulacro1.AddControllers
{
    [ApiController]
    [Route("api/Authors/Create")]

    public class AuthorCreateController : ControllerBase
    {
        private readonly IAuthorRepository _authorRepository;

        public AuthorCreateController(IAuthorRepository authorRepository)
        {
            _authorRepository = authorRepository;
        }
        [HttpPost]
        public IActionResult Create(Author author)
        {
            try
            {
                if (author == null)
                {
                    return BadRequest($"Datos nulos");
                }
                _authorRepository.Create(author);
                return Ok(author);
            }
            catch (Exception e)
            {
                return StatusCode(500, $"Error al crear el autor: {e.Message}");
            }
        }
    }
}