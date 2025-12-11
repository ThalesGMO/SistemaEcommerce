using System.Dynamic;
using SistemaEcommerce.Classe;

namespace SistemaEcommerce.Classes;

public class ProdutoVirtual : Produto
{
    public double TamanhoMb { get; private set; }
    public ProdutoVirtual(string nome, decimal preco, string CodigoProduto, double tamanhoMb) : base(nome, preco, CodigoProduto)
    {
        SetTamanho(tamanhoMb);
    }

    public string SetTamanho(double tamanhoMb)
    {
        if (tamanhoMb <= 0)
            return null;

        TamanhoMb = tamanhoMb;
        return "Tamanho do produto cadastrado com sucesso!";
    }
    public override string ToString()
    {
        return @$"
        Nome: {Nome}
        Preco: {Preco}
        String: {CodigoProduto}
        Tamanho em Mb: {TamanhoMb}";
    }
}
