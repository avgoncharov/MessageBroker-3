using MessageBroker.Messages;
using MessageBroker.Subscribers;
using System;
using System.Collections.Generic;

namespace MessageBroker
{
    public class MyMessageBroker
    {
        private List<ISubscriber> _subscribers;

        public MyMessageBroker()
        {
            _subscribers = new List<ISubscriber>();
        }

        public void Post(IMessage message)
        {
            foreach(var sub in _subscribers)
            {
                sub.AcceptMessage(message);
            }
        }

        public void Subscribe(ISubscriber subscriber)
        {
            if (!_subscribers.Contains(subscriber))
            {
                _subscribers.Add(subscriber);
            }
        }

        public void Unsubscribe(ISubscriber subscriber)
        {
            if (_subscribers.Contains(subscriber))
            {
                _subscribers.Remove(subscriber);
            }
        }
    }
}
