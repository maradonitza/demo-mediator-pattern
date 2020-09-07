using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorDemo
{
    public abstract class Person
    {
        public Person(string nickname) 
        {
           this.Nickname = nickname;
        }
        public string Nickname { get; set; }
        public abstract void HandleNotification(string from, string notification);
    }
}
