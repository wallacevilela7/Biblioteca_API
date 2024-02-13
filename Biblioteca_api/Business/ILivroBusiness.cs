using Biblioteca_api.Model;

namespace Biblioteca_api.Business
{
    public interface ILivroBusiness
    {
        public List<Livro> FindAll();
        public Livro FindById(int id);
        public Livro Update(Livro livro);
        public Livro Create(Livro livro);
        public void Delete(int id);
    }
}
