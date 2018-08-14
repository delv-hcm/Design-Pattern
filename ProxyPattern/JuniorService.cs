using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
 public   class JuniorService:EmployeeService
    {
        public void Authenticate(string user, string pass)
        {
            Console.WriteLine("Authenticate Junior {0}",user);
        }
    }
}
