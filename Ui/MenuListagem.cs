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
}