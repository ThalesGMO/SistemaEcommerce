using System.Security.Cryptography;
using SistemaEcommerce.Classe;
using SistemaEcommerce.Service;

namespace SistemaEcommerce.Ui;

public class MenuAdicaoProduto
{
    public MenuAdicaoProduto(ProdutoService produtoService)
    public void MenuAdicao()
    {
        Console.WriteLine("============ADIÇÃO DE PRODUTO============");
        Console.WriteLine("[1] - Produto Físico");
        Console.WriteLine("[2] - Produto Virtual");
        Console.WriteLine("[3] - Retornar ao menu principal");
        Console.Write("Selecione o tipo de produto: ");

        string escolha = Console.ReadLine();
        switch(escolha)
        {
            case "1": AdidionarProdutoFisico(); break;
            case "2": break;
            case "3": return; break;    
        }
    }

    public void AdidionarProdutoFisico()
    {
        string nome = Helper.ValidarString("Digite o nome do produto");
        string codigo = Helper.ValidarString("Digite o código do produto");
        decimal preco = Helper.ValidarDecimal("Digite o preço do produto");
        int quantidade = Helper.Validarint("Digite a quantidade inicial de estoque do produto");
    
    }
}