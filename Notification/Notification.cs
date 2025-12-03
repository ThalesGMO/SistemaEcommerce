using SistemaEcommerce.Interfaces;

namespace SistemaEcommerce.Interface;

public class Notification : INotification
{
    List<string> notificacoes = new List<string>();

    public void AdicionarNotificacao(string mensagem)
    {
        notificacoes.Add(mensagem);
    }

    public void LerNotificacoes()
    {
        foreach (string notificacao in notificacoes)
            Console.WriteLine(notificacao);
    }

    public void LimparNotificacoes()
    {
        notificacoes.Clear();
    }

    public bool TemNotificacao()
    {
        return notificacoes.Count() > 0;
    }
}