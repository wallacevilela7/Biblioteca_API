using Biblioteca_api.Model;

namespace Biblioteca_api.Repository
{
    public interface ILivroRepository
    {
        public List<Livro> FindAll();
        public Livro FindById(int id);
        public Livro Update(Livro livro);
        public Livro Create(Livro livro);
        public void Delete(int id);
    }
}
