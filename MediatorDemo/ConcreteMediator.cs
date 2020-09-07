using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MediatorDemo
{
    public class ConcreteMediator : Mediator
    {
        public List<Person> persons = new List<Person>();
        public void Register(Person person)
        {
            persons.Add(person);
            person.SetMediator(this);
        }
        public override void Send(Person person, string notification)
        {
            this.persons.Where(p => p != person).ToList().ForEach(p => p.HandleNotification(person.Nickname, notification));
        }
    }
}
