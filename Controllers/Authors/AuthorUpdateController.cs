using Microsoft.AspNetCore.Mvc;
using Simulacro1.Models;
using Simulacro1.Services;

namespace Simulacro1.AddControllers
{
    [ApiController]
    [Route("api/Authors/Update")]

    public class AuthorUpdateController : ControllerBase
    {
        private readonly IAuthorRepository _authorRepository;

        public AuthorUpdateController(IAuthorRepository authorRepository)
        {
            _authorRepository = authorRepository;
        }
        [HttpPut("{id}")]
        public IActionResult UpdateAuthor(Author author)
        {
            try
            {
                if (author == null)
                {
                    return BadRequest($"Los datos son nulos");
                }
                _authorRepository.Update(author);
                return Ok($"El autor {author.Name} {author.LastName} ha sido actualizado");
            }
            catch (Exception e)
            {
                return StatusCode(500, $"Error al actualizar el autor: {e.Message}");
            }
        }
    }
}