using Microsoft.AspNetCore.Mvc;

namespace Simulacro1.Services
{
    [ApiController]
    [Route("/api/Editorials/Active")]
    public class EditorialActiveController : ControllerBase
    {
        private readonly IEditorialRepository _editorialRepository;
        public EditorialActiveController(IEditorialRepository editorialRepository)
        {
            _editorialRepository = editorialRepository;
        }
        [HttpPut("{id}")]
        public IActionResult ActiveEditorial(int id)
        {
            try
            {
                var editorial = _editorialRepository.GetOne(id);
                if (editorial.Status == "Active")
                {
                    return Ok($"La editorial {editorial.Name} ya se encuentra activo");
                }else{
                    _editorialRepository.Active(editorial);
                    return Ok($"La editorial {editorial.Name} ha cambiado de estado a activo");
                }
            }
            catch (Exception e)
            {
                return StatusCode(500, $"Error al cambiar el estado: {e.Message}");
            }
        }
    }
}