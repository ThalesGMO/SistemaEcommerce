using SistemaEcommerce.Enum;

namespace SistemaEcommerce.Interfaces;

public interface INotification
{
    public bool TemNotificacao();
    public (string, NotificationEnum) ObterNotificacao();
    public void AdicionarNotificacao(string mensagem, NotificationEnum tipoNotificacao);
    public void ExibirNotificacao();
}
