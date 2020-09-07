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
            mediator.Comedian1 = comedian1;
            mediator.Comedian2 = comedian2;

            mediator.Send(comedian2, "Hey, I made a video making fun of corporate jargon.");
            mediator.Send(comedian1, "I see, dealing with cross-cutting concerns!");

            Console.ReadLine();
        }
    }
}
