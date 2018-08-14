using System;
using Factory.Factory;
using Factory.Model;
namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            HrFactory factory = new HrFactory();
            Employee emp1 = factory.GetType("Manager");
            Employee emp2 = factory.GetType("Programer");
            Employee emp3 = factory.GetType("Tester");
            emp1.work();
            emp2.work();
            emp3.work();
            Console.ReadKey();
        }
    }
}
