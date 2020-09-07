using System;

namespace MediatorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var mediator = new ConcreteMediator();
            
            var comedian1 = mediator.CreatePerson<Comedian>("Max Amini");
            var comedian2 = mediator.CreatePerson<Comedian>("Maz Jobrani");
            var comedian3 = mediator.CreatePerson<Comedian>("Carrey");

            comedian2.Send("Hey, I made a video making fun of corporate jargon.");
            comedian1.Send("I see, dealing with cross-cutting concerns!");

            Console.ReadLine();
        }
    }
}
