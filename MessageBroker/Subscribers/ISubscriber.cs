using MessageBroker.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace MessageBroker.Subscribers
{
    public interface ISubscriber
    {
        void AddSubscriber(ISubscriber subscriber);
        void RemoveSubscriber(ISubscriber subscriber);
        void Post(IMessage message);
        void AcceptMessage(IMessage message);
    }
}
