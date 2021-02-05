using MessageBroker.Messages;
using MessageBroker.Subscribers;
using System;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var vasya = new Subscriber1("Vasya");
            var petia = new Subscriber1("petia");
            var kolya = new Subscriber1("kolya");
            var vike = new Subscriber1("vika");

            vasya.AddSubscriber(petia);
            vasya.AddSubscriber(kolya);

            kolya.AddSubscriber(vike);

            vike.AddSubscriber(vasya);

            vasya.Post(new SimpleMessage("hello"));
            kolya.Post(new SimpleMessage("imgay"));
            vike.Post(new SimpleMessage("vi"));
            petia.Post(new SimpleMessage("kek"));

            vasya.RemoveSubscriber(petia);
            vasya.Post(new SimpleMessage("after"));
        }
    }
}
