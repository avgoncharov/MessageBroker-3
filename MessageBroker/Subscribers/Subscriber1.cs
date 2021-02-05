using MessageBroker.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace MessageBroker.Subscribers
{
    public class Subscriber1 : ISubscriber
    {
        private MyMessageBroker _messageBroker;
        public string Name { get; set; }

        public Subscriber1(string name)
        {
            _messageBroker = new MyMessageBroker();
            Name = name;
        }

        public void AcceptMessage(IMessage message)
        {
            Console.WriteLine($"{Name} получил {message.GetMessage()}");
        }

        public void Post(IMessage message)
        {
            _messageBroker.Post(message);
        }

        public void AddSubscriber(ISubscriber subscriber)
        {

            _messageBroker.Subscribe(subscriber);
        }

        public void RemoveSubscriber(ISubscriber subscriber)
        {
            _messageBroker.Unsubscribe(subscriber);
        }
    }
}
