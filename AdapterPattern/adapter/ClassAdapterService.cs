using Adapter.service;
namespace Adapter.adapter
{
    /// <summary>
    /// Adapter inherit from Employee service and Hr service
    /// </summary>
    /// <seealso cref="Adapter.service.HrService" />
    /// <seealso cref="Adapter.service.EmployeeService" />
    public class ClassAdapterService : HrService, EmployeeService
    {
        public string getDetails(int id)
        {
            return getStatus(id) + getSalary(id);
        }
    }
}
