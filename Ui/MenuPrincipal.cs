using SistemaEcommerce.Interfaces;
using SistemaEcommerce.Service;

namespace SistemaEcommerce.Ui;

public class MenuPrincipal
{
    private ProdutoService ServiceGlobal;
    private INotification NotificationGlobal;

    public MenuPrincipal(ProdutoService serviceRecebida, INotification notificationGlobal)
    {
        ServiceGlobal = serviceRecebida;
        NotificationGlobal = notificationGlobal;
    }

    public void Menu()
    {
        bool loop = true;
        while (loop)
        {
            Console.WriteLine("========MENU GESTÃO========");
            Console.WriteLine("[1] - Adicionar Produto");
            Console.WriteLine("[2] - Remover Produto");
            Console.WriteLine("[3] - Listar Produtos");
            Console.WriteLine("[4] - Atualizar Produto");
            Console.WriteLine("[5] - Sair");

            string escolha = Console.ReadLine();
            switch(escolha)
            {
                case "1":
                    {
                        MenuAdicaoProduto menuAdicao = new MenuAdicaoProduto(ServiceGlobal, NotificationGlobal);
                        menuAdicao.MenuAdicao();
                        break;
                    }  
                case "2":  break;
                case "3":  break;
                case "4":  break;
                case "5": loop = false; break;
            }
        }


    }
}