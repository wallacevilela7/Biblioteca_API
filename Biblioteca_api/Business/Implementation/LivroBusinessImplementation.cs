using Biblioteca_api.Model;
using Biblioteca_api.Repository;

namespace Biblioteca_api.Business.Implementation
{
    public class LivroBusinessImplementation : ILivroBusiness
    {
        private readonly ILivroRepository _repository;

        public LivroBusinessImplementation(ILivroRepository repository)
        {
            _repository = repository;
        }

        public Livro Create(Livro livro)
        {
            return _repository.Create(livro);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public List<Livro> FindAll()
        {
            return _repository.FindAll();
        }

        public Livro FindById(int id)
        {
            return _repository.FindById(id);
        }

        public Livro Update(Livro livro)
        {
            return _repository.Update(livro);
        }
    }
}
