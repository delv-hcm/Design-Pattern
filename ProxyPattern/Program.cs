using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            ProxyService proxy = new ProxyService();
            proxy.Authenticate("DeLV1", "123");
            Console.ReadKey();
        }
    }
}
