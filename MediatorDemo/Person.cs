using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorDemo
{
    public abstract class Person
    {
        protected Mediator mediator;
        public string Nickname { get; set; }
        public Person(Mediator mediator, string nickname)
        {
            this.mediator = mediator;
            this.Nickname = nickname;
        }
        public virtual void Send(string notification)
        {
            this.mediator.Send(this, notification);
        }
        public abstract void HandleNotification(string from, string notification);
    }
}
