using System;
using System.Collections.Generic;
using System.Text;

namespace MessageBroker.Messages
{
    public interface IMessage
    {
        string GetMessage();
    }
}
