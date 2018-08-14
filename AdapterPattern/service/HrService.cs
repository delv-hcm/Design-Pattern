using System;
namespace Adapter.service
{
    /// <summary>
    /// Hr service
    /// </summary>
    public class HrService
    {
        public String getStatus(int id)
        {
            // Get employee status
            return "Status";
        }

        public int getSalary(int id)
        {
            // Get employee salary
            return id;
        }
    }
}
