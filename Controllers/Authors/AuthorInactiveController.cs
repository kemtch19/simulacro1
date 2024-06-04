using Microsoft.AspNetCore.Mvc;
using Simulacro1.Models;
using Simulacro1.Services;

namespace Simulacro1.AddControllers
{
    [ApiController]
    [Route("api/Authors/Inactive")]

    public class AuthorInactiveController : ControllerBase
    {
        private readonly IAuthorRepository _authorRepository;

        public AuthorInactiveController(IAuthorRepository authorRepository)
        {
            _authorRepository = authorRepository;
        }
        [HttpPut("{id}")]
        public IActionResult InactiveAuthor(int id)
        {
            try
            {
                var author=_authorRepository.GetOne(id);
                if (author.Status == "Inactive")
                {
                    return Ok($"El autor {author.Name} ya se encuentra Inactivo pai");
                }
                else
                {
                    _authorRepository.Inactive(author);
                    return Ok($"El autor {author.Name} ha cambiado de estado a inactivo");
                }
            }
            catch (Exception e)
            {
                return StatusCode(500, $"Error, al cambiar el estado del autor: {e.Message}");
            }
        }
    }
}