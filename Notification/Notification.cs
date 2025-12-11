using SistemaEcommerce.Enum;
using SistemaEcommerce.Interfaces;

namespace SistemaEcommerce.Interface;

public class Notification : INotification
{
    private readonly List<(string, NotificationEnum)> notificacoes = [];

    public void AdicionarNotificacao(string mensagem, NotificationEnum tipoNotificacao)
    {
        notificacoes.Add((mensagem, tipoNotificacao));
    }

    public bool TemNotificacao()
    {
        return notificacoes.Count >= 0;
    }

    public (string, NotificationEnum) ObterNotificacao()
    {
        var ultimaNotificacao = notificacoes.Last();
        notificacoes.Clear();
        return ultimaNotificacao;
    }

    public void ExibirNotificacao()
    {
        var notificacao = ObterNotificacao();
        Console.WriteLine($"{notificacao.Item2} - {notificacao.Item1}");
        return;
    }
}
