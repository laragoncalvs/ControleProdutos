using CADASTRO_PRODUTOS.Data;
using CADASTRO_PRODUTOS.Models;

namespace CADASTRO_PRODUTOS.Repository
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly BancoContext _bancoContext;

        public ProdutoRepository(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }
        public ProdutoModel Adicionar(ProdutoModel produto)
        {
            _bancoContext.Produtos.Add(produto);
            _bancoContext.SaveChanges();
            return produto;
        }

        public bool Apagar(int id)
        {
            ProdutoModel produtoDb = ListarId(id);

            if (produtoDb == null) throw new Exception("Houve um erro");

            _bancoContext.Produtos.Remove(produtoDb);
            _bancoContext.SaveChanges();
            return true;
  
        }

        public ProdutoModel Atualizar(ProdutoModel produto)
        {
            ProdutoModel produtoModelDb = ListarId(produto.ProdutoId);

            if (produtoModelDb == null) throw new Exception("Erro de identificação");

            produtoModelDb.Descricao = produto.Descricao;
            produtoModelDb.PesoLiquido = produto.PesoLiquido;
            produtoModelDb.Situacao = produto.Situacao;
            produtoModelDb.Unidade = produto.Unidade;
            produtoModelDb.DataModificacao = DateTime.Now;

            _bancoContext.Produtos.Update(produtoModelDb);
            _bancoContext.SaveChanges();
            return (produtoModelDb);
        }

        public List<ProdutoModel> Listar()
        {
            return _bancoContext.Produtos.ToList();
        }

        public ProdutoModel ListarId(int id)
        {
            return _bancoContext.Produtos.FirstOrDefault(x => x.ProdutoId == id);
        }
    }
}
