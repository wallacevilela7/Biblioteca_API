using Biblioteca_api.Model;
using Microsoft.EntityFrameworkCore;

namespace Biblioteca_api.Context
{
    public class SqlServerContext : DbContext
    {
        public SqlServerContext()
        {
        }

        public SqlServerContext(DbContextOptions<SqlServerContext> options) : base(options)
        {

        }

        public DbSet<Livro> Livro { get; set; }
    }
}
