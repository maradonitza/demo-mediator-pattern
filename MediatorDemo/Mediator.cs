using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorDemo
{
    public abstract class Mediator
    {
        public abstract void Send(Person person, string notification);
    }
}
