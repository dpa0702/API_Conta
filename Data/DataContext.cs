using Banco.Model;
using Microsoft.EntityFrameworkCore;

namespace Banco.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Conta> Contas { get; set; }
    }
}
