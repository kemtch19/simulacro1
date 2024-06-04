using Simulacro1.Data;
using Simulacro1.Models;

namespace Simulacro1.Services
{
    public class AuthorRepository : IAuthorRepository
    {
        private readonly Simulacro1Context _context;
        public AuthorRepository(Simulacro1Context context)
        {
            _context = context;
        }

        public IEnumerable<Author> GetAll()
        {
            return _context.Authors.ToList();
        }

        public Author GetOne(int id)
        {
            return _context.Authors.Find(id);
        }

        public void Create(Author author)
        {
            _context.Authors.Add(author);
            _context.SaveChanges();
        }

        public void Update(Author author)
        {
            _context.Authors.Update(author);
            _context.SaveChanges();
        }

        public void Inactive(Author author)
        {
            author.Status = "Inactive";
            _context.Authors.Update(author);
            _context.SaveChanges();
        }

        public void Active(Author author)
        {
            author.Status = "Active";
            _context.Authors.Update(author);
            _context.SaveChanges();
        }
    }
}