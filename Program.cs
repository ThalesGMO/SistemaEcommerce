
using SistemaEcommerce.Classe;
using SistemaEcommerce.Interface;
using SistemaEcommerce.Interfaces;
using SistemaEcommerce.Repository;
using SistemaEcommerce.Service;
using SistemaEcommerce.Ui;

class Program
{
    static void Main(string[] args)
    {
        IProdutoRepository produtoRepositoryGlobal = new ProdutoRepository();
        INotification notificationGlobal = new Notification();
        ProdutoService serviceGlobal = new ProdutoService(produtoRepositoryGlobal, notificationGlobal);
        MenuPrincipal menuPrincipal = new MenuPrincipal(serviceGlobal, notificationGlobal);
        menuPrincipal.Menu();
    }
}