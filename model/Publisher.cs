using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExample.model
{
    internal class Publisher
    {
        private List<ISubscriber> subscribers;
        public string ActualState { get; set; }

        public Publisher()
        {
            subscribers = new List<ISubscriber>();
            ActualState = string.Empty;
        }

        public void Subscribe(ISubscriber subscriber)
        {
            subscribers.Add(subscriber);
        }

        public void Unsubscribe(ISubscriber subscriber)
        {
            subscribers.Remove(subscriber);
        }

        public void NotifySubscribers()
        {
            foreach (ISubscriber subscriber in subscribers)
            {
                subscriber.update(this);
            }
        }

        public void BusinessLogic()
        {
            this.ActualState = "Stringa con ID: " + new Random().Next(1, 100);
            NotifySubscribers();
        }

    }
}
