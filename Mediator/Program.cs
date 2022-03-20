using Mediator.Structural;
using System;

namespace Mediator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var mediator = new ConcreteMediator();
            var c1 = new Colleague1(mediator);
            var c2 = new Colleague2(mediator);
            mediator.Colleague1 = c1;
            mediator.Colleague2 = c2;

            c1.Send("hello from c1");
            c2.Send("hi from c2");
        }
    }
}
