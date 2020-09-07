using System;

namespace MediatorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var mediator = new ConcreteMediator();
            var comedian1 = new Comedian("Max Amini"); 
            var comedian2 = new Comedian("Maz Jobrani");

            mediator.Register(comedian1);
            mediator.Register(comedian2);

            comedian2.Send("Hey, I made a video making fun of corporate jargon.");
            comedian1.Send("I see, dealing with cross-cutting concerns!");

            Console.ReadLine();
        }
    }
}
