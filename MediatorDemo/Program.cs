using System;

namespace MediatorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var mediator = new ConcreteMediator();
            var comedian1 = new Comedian(mediator, "Max Amini"); 
            var comedian2 = new Comedian(mediator, "Maz Jobrani");
            mediator.Comedian1 = comedian1;
            mediator.Comedian2 = comedian2;

            comedian2.Send("Hey, I made a video making fun of corporate jargon.");
            comedian1.Send("I see, dealing with cross-cutting concerns!");

            Console.ReadLine();
        }
    }
}
