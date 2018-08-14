using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
 public  class ProxyService:EmployeeService
    {
        private JuniorService _JuniorService;
        public ProxyService()
        {
            _JuniorService = new JuniorService();
        }
        public void Authenticate(string user, string pass)
        {
            _JuniorService.Authenticate(user, pass);
        }
    }
}
