using SistemaEcommerce.Classe;
using SistemaEcommerce.Interface;

namespace SistemaEcommerce.Repository;

public class ProdutoRepository : IProdutoRepository
{
    private List<Produto> produtos = new List<Produto>();

    public void AdicionarProduto(Produto produto)
    {
        produtos.Add(produto);
    }

    public void AtualizarProduto(string codigoProduto)
    {
        
    }

    public List<Produto> ListarProdutos()
    {
        return produtos;
    }

    public void RemoverProduto(Produto produtoRemido)
    {
        produtos.Remove(produtoRemido);
    }
}