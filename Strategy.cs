// Strategy för att skicka notifikationer.

using System;

namespace DesignPatterns
{
    public interface INotificationStrategy
    {
        void Send(string message);
    }

    public class EmailNotificationStrategy : INotificationStrategy
    {
        public void Send(string message)
        {
            Console.WriteLine($"Email Strategy: {message}");
        }
    }

    public class SMSNotificationStrategy : INotificationStrategy
    {
        public void Send(string message)
        {
            Console.WriteLine($"SMS Strategy: {message}");
        }
    }

    public class NotificationSender
    {
        private INotificationStrategy _strategy;

        public NotificationSender(INotificationStrategy strategy)
        {
            _strategy = strategy;
        }

        public void SetStrategy(INotificationStrategy strategy)
        {
            _strategy = strategy;
        }

        public void Send(string message)
        {
            _strategy.Send(message);
        }
    }
}
