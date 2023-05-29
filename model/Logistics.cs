using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExample.model
{
    internal abstract class Logistics
    {
        private ITransport transport;

        internal void PlanDelivery()
        {
            Console.WriteLine("Pianificando la consegna");
            this.transport = CreateTransport();
        }

        public abstract ITransport CreateTransport();

        internal void StartDelivery()
        {
            Console.WriteLine("Spedizione avviata");
        }
    }
}
