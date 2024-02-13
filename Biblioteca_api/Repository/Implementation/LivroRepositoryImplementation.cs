using Biblioteca_api.Context;
using Biblioteca_api.Model;

namespace Biblioteca_api.Repository.Implementation
{
    public class LivroRepositoryImplementation : ILivroRepository
    {
        private SqlServerContext _context;

        public LivroRepositoryImplementation(SqlServerContext context)
        {
            _context = context;
        }
        public Livro Create(Livro livro)
        {
            if (livro == null) return new Livro();
            try
            {
                _context.Livro.Add(livro);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
            return livro;
        }

        public void Delete(int id)
        {
            Livro result = _context.Livro.SingleOrDefault(lv => lv.Id == id);
            
            if(result != null)
            {
                _context.Remove(result);
                _context.SaveChanges();
            }
        }

        public List<Livro> FindAll()
        {
            return _context.Livro.ToList();
        }

        public Livro FindById(int id)
        {
            return _context.Livro.SingleOrDefault(lv => lv.Id == id);
        }

        public Livro Update(Livro livro)
        {
            Livro result = _context.Livro.SingleOrDefault(lv => lv.Id == livro.Id);

            if (result != null)
            {
                _context.Entry(result).CurrentValues.SetValues(livro);
                _context.SaveChanges();
            }
            return livro;
        }
    }
}
