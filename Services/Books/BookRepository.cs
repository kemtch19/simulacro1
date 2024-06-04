using Microsoft.EntityFrameworkCore;
using Simulacro1.Data;
using Simulacro1.Models;

namespace Simulacro1.Services
{
    public class BookRepository : IBookRepository
    {
        private readonly Simulacro1Context _context;
        public BookRepository(Simulacro1Context context)
        {
            _context = context;
        }
        public IEnumerable<Book> GetAll()
        {
            return _context.Books.ToList();
        }
    }
}