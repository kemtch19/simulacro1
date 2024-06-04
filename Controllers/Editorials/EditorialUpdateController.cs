using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Simulacro1.Models;
using Simulacro1.Services;

namespace Simulacro1.AddControllers
{
    [ApiController]
    [Route("api/Editorials/Update")]
    public class EditorialUpdateController : ControllerBase
    {
        private readonly IEditorialRepository _editorialRepository;
        public EditorialUpdateController(IEditorialRepository editorialRepository)
        {
            _editorialRepository = editorialRepository;
        }
        [HttpPut("{id}")]
        public IActionResult UpdateEditorial(Editorial editorial)
        {
            try
            {
                if (editorial == null)
                {
                    return BadRequest($"No hay datos");
                }
                _editorialRepository.Update(editorial); 
                return Ok($"Editorial {editorial.Name} con el id: {editorial.Id} actualizado con éxito");
            }
            catch (Exception e)
            {
                return StatusCode(500, $"Error al actualizar {editorial.Name} con el id: {editorial.Id} {e.Message}");
            }
        }
    }
}