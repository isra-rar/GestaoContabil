
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoContabil.Notifications
{
    public class Notification
    {

        public string Message { get; set; }

        public Notification(string message)
        {
            Message = message;
        }

    }
}
