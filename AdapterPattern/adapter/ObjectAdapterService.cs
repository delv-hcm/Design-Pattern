using Adapter.service;
namespace Adapter.adapter
{
    /// <summary>
    /// Adapter inherit from Hr service
    /// </summary>
    /// <seealso cref="Adapter.service.HrService" />
    public class ObjectAdapterService:HrService
    {
        private HrService hrservice = new HrService();
        public string GetDetails(int id)
        {
            return hrservice.getStatus(id) + hrservice.getSalary(id);
        }
    }
}
