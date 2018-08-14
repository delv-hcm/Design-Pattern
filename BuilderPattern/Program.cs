using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuilderPattern.Builder;
using BuilderPattern.Models;
namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var director = new Director(
             new EmployeeBuilder().SetAge(10).SetFirstName("David").SetLastName("Coperfield") );
            director.CreateEmployee();
            var emp = director.GetEmployee();
            Console.WriteLine(emp.ToString());
            Console.ReadKey();
        }
    }
}
