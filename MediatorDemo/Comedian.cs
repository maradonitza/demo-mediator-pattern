using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorDemo
{
    public class Comedian : Person
    {
        public Comedian(Mediator mediator, string nickname) : base(mediator, nickname)
        {
        }
        public override void HandleNotification(string from, string notification)
        {
            Console.WriteLine($"{Nickname} gets notification: {notification} (from {from})");
        }
    }
}
