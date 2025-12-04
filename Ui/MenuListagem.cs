using SistemaEcommerce.Interfaces;
using SistemaEcommerce.Service;

namespace SistemaEcommerce.Ui;

public class MenuListagem
{
    private ProdutoService Service;
    private INotification Notification;
    public MenuListagem(ProdutoService produtoService, INotification notificationRecebido)
    {
        Service = produtoService;
        Notification = notificationRecebido;
    }

    public void ListarProdutos()
    {
        Console.WriteLine("=============MENU DE LISTAGEM===============");
        Console.WriteLine("[1] - Produto físico");
        Console.WriteLine("[2] - Produto virtual");
        Console.WriteLine("[3] - Listar todos");

        string escolha = Console.ReadLine();
        Service.ListarProdutos(int.Parse(escolha));
    }
}