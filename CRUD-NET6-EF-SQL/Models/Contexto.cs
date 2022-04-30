using Microsoft.EntityFrameworkCore;
namespace CRUD_NET6_EF_SQL.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }

        public DbSet<Produto> Produto {get; set;}

    }
}
