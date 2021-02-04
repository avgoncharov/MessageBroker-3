using System;
using System.Collections.Generic;
using System.Text;

namespace MessageBroker.Messages
{
    public class SimpleMessage : IMessage
    {
        public string _message;
        public SimpleMessage(string message)
        {
            _message = message;
        }
        public string GetMessage()
        {
            return _message;
        }
    }
}
