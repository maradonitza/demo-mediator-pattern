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
        public T CreatePerson<T>(string nickname) where T : Person //, new()
        {
            //var c = new T();
            //c.Nickname = nickname;
            var person = (T)Activator.CreateInstance(typeof(T), new object[] { nickname });
            Register(person);
            return person;
        }

        public override void Send(Person person, string notification)
        {
            this.persons.Where(p => p != person).ToList().ForEach(p => p.HandleNotification(person.Nickname, notification));
        }
    }
}
