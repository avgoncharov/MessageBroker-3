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

            vasya.Post("hello");
            kolya.Post("imgay");
            vike.Post("vi");
            petia.Post("kek");

            vasya.RemoveSubscriber(petia);
            vasya.Post("after");
        }
    }
}
