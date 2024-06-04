using Simulacro1.Models;

namespace Simulacro1.Services
{
    public interface IBookRepository
    {
        public IEnumerable<Book> GetAll();
    }
}