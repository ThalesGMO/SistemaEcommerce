namespace SistemaEcommerce.Classe;

public abstract class Produto
{
    public string Nome {get; private set;} 
    public decimal Preco {get; private set;}
    public string CodigoProduto {get; private set;}

    public Produto(string nome, decimal preco, string codigoProduto)
    {
        Nome = nome;
        Preco = preco;
        CodigoProduto = codigoProduto;
    }
}