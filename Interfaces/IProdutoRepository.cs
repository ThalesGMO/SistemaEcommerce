using SistemaEcommerce.Classe;

namespace SistemaEcommerce.Interface;

public interface IProdutoRepository
{
    public void AdicionarProduto(Produto produto);
    public void RemoverProduto(Produto produtoRemovido);
    public List<Produto> ListarProdutos();
    public void AtualizarProduto(string codigoProduto);
}