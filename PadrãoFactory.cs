using System;

namespace MetodoFactory
{
    public abstract class Notificacao
    {
        public abstract void Enviar(string mensagem);
        public abstract Notificacao CriarNotificacao(); 
    }

    public class EmailNotificacao : Notificacao
    {
        public override void Enviar(string mensagem)
        {
            Console.WriteLine("Enviando e-mail: " + mensagem);
        }

        public override Notificacao CriarNotificacao()
        {
            return new EmailNotificacao();
        }
    }

    public class SMSNotificacao : Notificacao
    {
        public override void Enviar(string mensagem)
        {
            Console.WriteLine("Enviando SMS: " + mensagem);
        }

        public override Notificacao CriarNotificacao()
        {
            return new SMSNotificacao();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Notificacao fabrica = new EmailNotificacao();
            Notificacao notificacao = fabrica.CriarNotificacao();
            notificacao.Enviar("Olá! Esta é uma notificação de e-mail.");

            fabrica = new SMSNotificacao();
            notificacao = fabrica.CriarNotificacao();
            notificacao.Enviar("Olá! Esta é uma notificação de SMS.");
        }
    }
}
