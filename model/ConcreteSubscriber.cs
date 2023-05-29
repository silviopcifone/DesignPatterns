using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExample.model
{
    internal class ConcreteSubscriber : ISubscriber
    {
        private readonly int ID;

        public ConcreteSubscriber()
        {
            ID = new Random().Next(1, 100);
        }

        public void update(Publisher context)
        {
            Console.WriteLine("new state for "+ ID+" concrete subscriber: " + context.ActualState);
        }
    }
}
