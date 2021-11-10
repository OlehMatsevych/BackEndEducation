using System;

namespace Patterns
{
    public class NotificationStrategy
    {
        private readonly INotificationStrategy _notificationStrategy;
        public NotificationStrategy(INotificationStrategy notificationStrategy)
        {
            _notificationStrategy = notificationStrategy;
        }
        public void SendMessage(string msg)
        {
            _notificationStrategy.SendMessage(msg);
        }
    }

    public interface INotificationStrategy
    {
        void SendMessage(string msg);
    }
    public class EmailNotification : INotificationStrategy
    {
        public void SendMessage(string msg)
        {
            throw new NotImplementedException();
        }
    }
    public class PhoneNumberNotification : INotificationStrategy
    {
        public void SendMessage(string msg)
        {
            throw new NotImplementedException();
        }
    }
}
