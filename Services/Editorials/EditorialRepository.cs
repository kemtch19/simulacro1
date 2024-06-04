using Simulacro1.Data;
using Simulacro1.Models;

namespace Simulacro1.Services
{
    public class EditorialRepository : IEditorialRepository
    {
        private readonly Simulacro1Context _context;
        public EditorialRepository(Simulacro1Context context)
        {
            _context = context;
        }
        public IEnumerable<Editorial> GetAll()
        {
            return _context.Editorials.ToList();
        }
        public Editorial GetOne(int id)
        {
            return _context.Editorials.Find(id);
        }
        public void Create(Editorial editorial)
        {
            _context.Editorials.Add(editorial);
            _context.SaveChanges();
        }
        public void Update(Editorial editorial)
        {
            _context.Editorials.Update(editorial);
            _context.SaveChanges();
        }
        public void Inactive(Editorial editorial)
        {
            editorial.Status = "Inactive";
            _context.Editorials.Update(editorial);
            _context.SaveChanges();
        }
        public void Active(Editorial editorial)
        {
            editorial.Status = "Active";
            _context.Editorials.Update(editorial);
            _context.SaveChanges();
        }
    }
}