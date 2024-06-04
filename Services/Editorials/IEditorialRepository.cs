using Simulacro1.Models;

namespace Simulacro1.Services
{
    public interface IEditorialRepository
    {
        public IEnumerable<Editorial> GetAll();
        public Editorial GetOne(int id);
        public void Create(Editorial editorial);
        public void Update(Editorial editorial);
        public void Inactive(Editorial editorial);
        public void Active(Editorial editorial);
    }
}