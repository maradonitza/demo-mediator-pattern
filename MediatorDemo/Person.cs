using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorDemo
{
    public abstract class Person
    {
        protected Mediator mediator;
        public string Nickname { get; }
        public Person(string nickname)
        {
            this.Nickname = nickname;
        }
        internal void SetMediator(Mediator mediator)
        {
            this.mediator = mediator;
        }
        public virtual void Send(string notification)
        {
            this.mediator.Send(this, notification);
        }
        public abstract void HandleNotification(string from, string notification);
    }
}
