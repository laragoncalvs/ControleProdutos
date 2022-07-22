using CADASTRO_PRODUTOS.Models;
using Microsoft.EntityFrameworkCore;

namespace CADASTRO_PRODUTOS.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {

        }

        public DbSet<ProdutoModel> Produtos { get; set; }
    }
}
