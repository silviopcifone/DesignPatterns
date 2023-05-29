using DesignPatternExample.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExample
{
    internal class Test
    {
        public static void Main(string[] args)
        {
            //Implementazione Singleton
            Singleton s1 = Singleton.GetInstance();
            Console.WriteLine(s1.ToString());
            Singleton s2 = Singleton.GetInstance();
            Console.WriteLine(s2.ToString());

            //Implementazione Factory
            Logistics shipLogistics = new ShipLogistics();
            shipLogistics.PlanDelivery();
            shipLogistics.StartDelivery();

            Logistics truckLogistics = new TruckLogistics();
            truckLogistics.PlanDelivery();
            truckLogistics.StartDelivery();


            //Implementation Proxy
            INotepadService proxy = new NotepadProxy(new NotepadService());
            string text = proxy.GetText();

            text = proxy.GetText();


            //Implementation Adapter
            Adapter adapter = new Adapter();
            adapter.method("ciao");


            //Implementation Observer
            Publisher publisher = new Publisher();
            ISubscriber firstSubscriber = new ConcreteSubscriber();
            ISubscriber secondSubscriber = new ConcreteSubscriber();
            publisher.Subscribe(firstSubscriber);
            publisher.Subscribe(secondSubscriber);

            publisher.BusinessLogic();
            publisher.BusinessLogic();
            publisher.BusinessLogic();
            

            //Test Generics
            Dictionary<string, string> map = new Dictionary<string, string>();

            GenericsTest<Ship> test = new GenericsTest<Ship>();

            test.GetValue();
        }
    }
}
