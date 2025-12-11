using SistemaEcommerce.Classe;
using SistemaEcommerce.Interfaces;
using SistemaEcommerce.Service;

namespace SistemaEcommerce.Ui;

public class MenuRemocaoProduto
{
    private INotification Inotification;
    private ProdutoService ProdutoService;

    public MenuRemocaoProduto(INotification notificationRecebido, ProdutoService produtoServiceRecebido)
    {
        Inotification = notificationRecebido;
        ProdutoService = produtoServiceRecebido;
    }

    public void MenuRemocao()
    {
        Console.WriteLine("=============MENU DE LISTAGEM===============");
        Console.WriteLine("[1] - Produto físico");
        Console.WriteLine("[2] - Produto virtual");
        Console.WriteLine("[3] - Listar todos");
        Console.WriteLine("Qual tipo do produto que você gostaria de remover");

        string escolha = Console.ReadLine();
        ProdutoService.ListarProdutos(int.Parse(escolha));

        string codigoEscolhido = Helper.ValidarString("Digite o código do produto que você quer remover");
        ProdutoService.RemoverProduto(escolha);

        
        
    }
}
