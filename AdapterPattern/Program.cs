using System;
using Adapter.adapter;
namespace Adapter
{
    //Adapter pattern acts as a bridge between two incompatible interfaces.
    // This pattern involves a single class called adapter which is responsible 
    //for communication between two independent or incompatible interfaces

    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();
            client.ShowDetail(200);
            client.ShowDetail2(100);
            client.ShowDetail3(new ClassAdapterService(), 3);
      
            Console.ReadKey();
        }
    }
}
