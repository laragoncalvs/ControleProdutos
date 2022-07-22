using CADASTRO_PRODUTOS.Enums;
using System.ComponentModel.DataAnnotations;

namespace CADASTRO_PRODUTOS.Models
{
    public class ProdutoModel
    {
        public ProdutoModel()
        {
            DataCadastro = DateTime.Now;
        }
        [Key]
        public int ProdutoId { get; set; }
        public string Descricao { get; set; }
        public SituacaoEnum Situacao { get; set; }
        public UnidadeEnum Unidade { get; set; }
        public decimal PesoLiquido { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime? DataModificacao { get; set; }

    }
}
