using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorDemo
{
    public class ConcreteMediator : Mediator
    {
        public Comedian Comedian1 { get; set; }
        public Comedian Comedian2 { get; set; }
        public override void Send(Person person, string notification)
        {
            var author = (Comedian)person;
            if (author == this.Comedian1)
            {
                this.Comedian2.HandleNotification(author.Nickname, notification);
            }
            else
            {
                this.Comedian1.HandleNotification(author.Nickname, notification);
            }
        }
    }
}
