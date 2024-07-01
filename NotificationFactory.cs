// Factory Method for att skapa notifikationer.

using System;

namespace DesignPatterns
{
    public interface INotification
    {
        void Notify(string message);
    }

    public class EmailNotification : INotification
    {
        public void Notify(string message)
        {
            Console.WriteLine($"Sending Email: {message}");
        }
    }

    public class SMSNotification : INotification
    {
        public void Notify(string message)
        {
            Console.WriteLine($"Sending SMS: {message}");
        }
    }

    public abstract class NotificationFactory
    {
        public abstract INotification CreateNotification();
    }

    public class EmailNotificationFactory : NotificationFactory
    {
        public override INotification CreateNotification()
        {
            return new EmailNotification();
        }
    }

    public class SMSNotificationFactory : NotificationFactory
    {
        public override INotification CreateNotification()
        {
            return new SMSNotification();
        }
    }
}
