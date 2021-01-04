using GestaoContabil.Notifications;
using System.Collections.Generic;


namespace GestaoContabil.Interfaces
{
    public interface INotifier
    {
        bool HaveNotification();
        List<Notification> GetNotifications();
        void Handle(Notification notification);
    }
}
