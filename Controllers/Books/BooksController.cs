using Microsoft.AspNetCore.Mvc;
using Simulacro1.Models;
using Simulacro1.Services;

namespace Simulacro1.AddControllers
{
    [ApiController]
    [Route("api/[Controller]")]

    public class BooksController : ControllerBase
    {
        private readonly IBookRepository _bookRepository;

        public BooksController(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }
        [HttpGet]
        public ActionResult<IEnumerable<Book>> GetBooks()
        {
            try
            {
                return Ok(_bookRepository.GetAll());
            }
            catch (Exception e)
            {
                return StatusCode(500, $"Error no se pudo obtener el listado de libros: {e.Message}");
            }
        }
    }
}