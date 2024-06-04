using Simulacro1.Models;

namespace Simulacro1.Services{
    public interface IAuthorRepository{
        public IEnumerable<Author> GetAll();
        public Author GetOne(int id);
        public void Create(Author author);
        public void Update(Author author);
        public void Inactive(Author author);
        public void Active(Author author);
    }
}