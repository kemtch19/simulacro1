using Microsoft.AspNetCore.Mvc;
using Simulacro1.Models;

namespace Simulacro1.Services
{
    [ApiController]
    [Route("api/Editorials/Inactive")]
    public class EditorialInactiveController : ControllerBase
    {
        private readonly IEditorialRepository _editorialRepository;
        public EditorialInactiveController(IEditorialRepository editorialRepository)
        {
            _editorialRepository = editorialRepository;
        }
        [HttpPut("{id}")]
        public IActionResult InactiveEditorial(int id)
        {
            try
            {
                var editor = _editorialRepository.GetOne(id);
                if(editor.Status=="Inactive"){
                    return Ok($"La Editorial {editor.Name} ya se encuentra inactivo");
                }else{
                    _editorialRepository.Inactive(editor);
                    return Ok($"La Editorial {editor.Name} ha cambiado de estado a inactivo");
                }
            }
            catch (Exception e)
            {
                return StatusCode(500, $"Error al cambiar el estado de la editorial: {e.Message}");
            }
        }
    }
}