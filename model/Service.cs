using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExample.model
{
    internal class Service
    {
        public void ServiceMethod(int value)
        {
            Console.WriteLine("Adapter Service result: " + value);
        }
    }
}
