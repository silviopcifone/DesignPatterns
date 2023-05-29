using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExample.model
{
    internal class Ship : ITransport
    {
        public int Id = 0;

        public Ship()
        {
            this.Id = GenerateId();
            Console.WriteLine("Ship creato con Id: " + Id);
        }

        public int GenerateId()
        {
            return new Random().Next(1, 100);
        }
    }
}
