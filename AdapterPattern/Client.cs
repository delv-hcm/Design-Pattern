using System;
using Adapter.adapter;
using Adapter.service;
namespace Adapter
{
    /// <summary>
    /// Client want to use service from EmployeeService, but don't rule access to EmployeeService. So, it can access
    /// throught Adapter
    /// </summary>
    public class Client
    {
        private ClassAdapterService service;
        private ObjectAdapterService Objservice;
        public Client()
        {
            service = new ClassAdapterService();
            Objservice = new ObjectAdapterService();
        }
        /// <summary>Shows the detail of Employee use EmployeeService</summary>
        /// <param name="id">The identifier.</param>
        public void ShowDetail(int id)
        {
            Console.WriteLine(service.getDetails(id));
        }
        /// <summary>Shows the detail of Employee use HrService</summary>
        /// <param name="id">The identifier.</param>
        public void ShowDetail2(int id)
        {
            Console.WriteLine(Objservice.GetDetails(id));
        }
        public void ShowDetail3(EmployeeService service, int id)
        {
            Console.WriteLine(service.getDetails(id));
        }
    }
}
