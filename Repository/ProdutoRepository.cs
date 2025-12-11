using SistemaEcommerce.Classe;
using SistemaEcommerce.Interface;

namespace SistemaEcommerce.Repository;

public class ProdutoRepository : IProdutoRepository
{
    private readonly List<Produto> produtos = [];

    public void AdicionarProduto(Produto produto)
    {
        produtos.Add(produto);
    }

    public void AtualizarProduto(string codigoProduto)
    {
        //Lógica de atualização de produto
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
