using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorDemo
{
    public class Comedian : Person
    {
        public Comedian(string nickname): base(nickname)
        {
        }
        public override void HandleNotification(string from, string notification)
        {
            Console.WriteLine($"{Nickname} gets notification: {notification} (from {from})");
        }
    }
}
