using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExample.model
{
    internal class Adapter : IClient
    {
        private Service adaptee;

        public Adapter()
        {
            adaptee = new Service();
        }

        public void method(string data)
        {
            int specialData = data.Length;
            adaptee.ServiceMethod(specialData);
        }
    }
}
