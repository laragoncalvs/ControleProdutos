using CADASTRO_PRODUTOS.Models;

namespace CADASTRO_PRODUTOS.Repository
{
    public interface IProdutoRepository
    {
        ProdutoModel Adicionar(ProdutoModel produto);
        ProdutoModel Atualizar(ProdutoModel produto);
        List<ProdutoModel> Listar();
        ProdutoModel ListarId(int id);
        bool Apagar(int id);
    }
}