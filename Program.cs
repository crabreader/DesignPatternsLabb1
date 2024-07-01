// Jag har implementerat designmönstrena Factory Method, Strategy och Singleton.

using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            // Factory Method
            NotificationFactory emailFactory = new EmailNotificationFactory();
            INotification emailNotification = emailFactory.CreateNotification();
            emailNotification.Notify("Hello via Email!");

            NotificationFactory smsFactory = new SMSNotificationFactory();
            INotification smsNotification = smsFactory.CreateNotification();
            smsNotification.Notify("Hello via SMS!");

            // Singleton
            Logger logger = Logger.Instance;
            logger.Log("This is a singleton logger.");

            // Strategy
            NotificationSender sender = new NotificationSender(new EmailNotificationStrategy());
            sender.Send("This is an email notification strategy.");

            sender.SetStrategy(new SMSNotificationStrategy());
            sender.Send("This is an SMS notification strategy.");
        }
    }
}
