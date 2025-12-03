
using SistemaEcommerce.Classe;
using SistemaEcommerce.Interface;
using SistemaEcommerce.Interfaces;

namespace SistemaEcommerce.Classes;

public class ProdutoFisico : Produto 
{
    public int QuantidadeEstoque {get; private set;}
    public ProdutoFisico(string nome, decimal preco, string CodigoProduto, int quantidadeEstoque) : base(nome, preco, CodigoProduto)
    {
        SetEstoque(quantidadeEstoque);
    }

    public string SetEstoque(int quantidadeEstoque)
    {
        if (quantidadeEstoque < 10)
            return null;

        QuantidadeEstoque = quantidadeEstoque;
        return "Quantidade atribuida com sucesso";
    }

    public string BaixarEstoque(int quantidade)
    {
        if (QuantidadeEstoque < quantidade)
            return null;

        QuantidadeEstoque -= quantidade;
        return $"Foram retiradas {quantidade} unidades de {Nome}, estoque atual: {QuantidadeEstoque}";
    }

    public string AdicionarEstoque(int quantidade)
    {
        QuantidadeEstoque += quantidade;
        return $"Foram adicionadas mais {quantidade} de {Nome} ao estoque";
    }
    
}
