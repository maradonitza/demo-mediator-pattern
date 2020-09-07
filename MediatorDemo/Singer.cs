using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorDemo
{
    public class Singer : Person
    {
        public Singer(string nickname) : base(nickname)
        {
        }

        public override void HandleNotification(string from, string notification)
        {
            Console.WriteLine($"{Nickname} gets notification: {notification} (from {from})");
        }

    }
}
