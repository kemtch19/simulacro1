using Microsoft.AspNetCore.Mvc;
using Simulacro1.Models;
using Simulacro1.Services;

namespace Simulacro1.AddControllers
{
    [ApiController]
    [Route("api/Authors/Active")]

    public class AuthorActiveController : ControllerBase
    {
        private readonly IAuthorRepository _authorRepository;

        public AuthorActiveController(IAuthorRepository authorRepository)
        {
            _authorRepository = authorRepository;
        }
        [HttpPut("{id}")]
        public IActionResult Put(int id)
        {
            try
            {
                var author=_authorRepository.GetOne(id);
                if (author.Status == "Active")
                {
                    return Ok($"El autor {author.Name} ya se encuentra Activo pai");
                }
                else
                {
                    _authorRepository.Active(author);
                    return Ok($"El autor {author.Name} ha cambiado de estado a Activo");
                }
            }
            catch (Exception e)
            {
                return StatusCode(500, $"Error al cambiar el estado del autor {e.Message}");
            }
        }
    }
}