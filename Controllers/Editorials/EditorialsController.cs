using Microsoft.AspNetCore.Mvc;
using Simulacro1.Models;
using Simulacro1.Services;

namespace Simulacro1.AddControllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class EditorialsController : ControllerBase
    {
        private readonly IEditorialRepository _editorialRepository;
        public EditorialsController(IEditorialRepository editorialRepository)
        {
            _editorialRepository = editorialRepository;
        }
        [HttpGet]
        public ActionResult<IEnumerable<Editorial>> GetEditorials()
        {
            try
            {
                return Ok(_editorialRepository.GetAll());
            }
            catch (Exception e)
            {
                return StatusCode(500, $"Error, editorial no se encontro: {e.Message}");
            }
        }
        [HttpGet("{id}")]
        public IActionResult GetEditorial(int id)
        {
            try
            {
                var editorial = _editorialRepository.GetOne(id);
                if (editorial == null)
                {
                    return NotFound($"No se encontro la editorial con el id {id}");
                }
                return Ok(editorial);
            }
            catch (Exception e)
            {
                return StatusCode(500, $"Error, editorial no se encontro: {e.Message}");
            }
        }
    }
}