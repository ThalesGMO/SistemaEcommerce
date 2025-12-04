using System.Security.Cryptography;
using SistemaEcommerce.Classe;
using SistemaEcommerce.Interfaces;
using SistemaEcommerce.Service;

namespace SistemaEcommerce.Ui;

public class MenuAdicaoProduto
{
    private ProdutoService Service;
    private INotification Notification;
    public MenuAdicaoProduto(ProdutoService produtoService, INotification notificationGlobal)
    {
        Service = produtoService;
        Notification = notificationGlobal;
    }

    public void MenuAdicao()
    {
        Console.WriteLine("============ADIÇÃO DE PRODUTO============");
        Console.WriteLine("[1] - Produto Físico");
        Console.WriteLine("[2] - Produto Virtual");
        Console.WriteLine("[3] - Retornar ao menu principal");
        Console.Write("Selecione o tipo de produto: ");

        string escolha = Console.ReadLine();
        switch (escolha)
        {
            case "1": AdidionarProdutoFisico(); break;
            case "2": AdidionarProdutoVirtual(); break;
            case "3": return;
        }
    }

    public void AdidionarProdutoFisico()
    {
        string nome = Helper.ValidarString("Digite o nome do produto");
        string codigo = Helper.ValidarString("Digite o código do produto");
        decimal preco = Helper.ValidarDecimal("Digite o preço do produto");
        int quantidade = Helper.Validarint("Digite a quantidade inicial de estoque do produto");

        Service.AdicionarProdutoFisico(nome, preco, codigo, quantidade);

        if (Notification.TemNotificacao())
        {
            Notification.LerNotificacoes();
            Notification.LimparNotificacoes();
            return;
        }
        Console.WriteLine("Produto físico adicionado com sucesso");
    }

    public void AdidionarProdutoVirtual()
    {
        string nome = Helper.ValidarString("Digite o nome do produto");
        string codigo = Helper.ValidarString("Digite o código do produto");
        decimal preco = Helper.ValidarDecimal("Digite o preço do produto");
        double tamanhoMb = Helper.ValidarDouble("Digite a quantidade inicial de estoque do produto");

        Service.AdicionarProdutoVirtual(nome, preco, codigo, tamanhoMb);

        if (Notification.TemNotificacao())
        {
            Notification.LerNotificacoes();
            Notification.LimparNotificacoes();
            return;
        }
        Console.WriteLine("Produto físico adicionado com sucesso");
    }
}