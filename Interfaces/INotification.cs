using SistemaEcommerce.Interface;

namespace SistemaEcommerce.Interfaces;

    public interface INotification
    {
        public void AdicionarNotificacao(string mensagem);   
        public void LimparNotificacoes();     
        public void LerNotificacoes();
        public bool TemNotificacao();
    }