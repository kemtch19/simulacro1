using Microsoft.AspNetCore.Mvc;
using Simulacro1.Models;
using Simulacro1.Services;

namespace Simulacro1.AddControllers
{
    [ApiController]
    [Route("api/Editorials/Create")]
    public class EditorialCreateController : ControllerBase
    {
        private readonly IEditorialRepository _editorialRepository;
        public EditorialCreateController(IEditorialRepository editorialRepository)
        {
            _editorialRepository = editorialRepository;
        }
        [HttpPost]
        public IActionResult Create(Editorial editorial)
        {
            try
            {
                if (editorial == null)
                {
                    return BadRequest($"Datos nulos");
                }
                _editorialRepository.Create(editorial);
                return Ok(editorial);
            }
            catch (Exception e)
            {
                return StatusCode(500, $"Error al crear la editorial: {e.Message}");
            }
        }
    }
}