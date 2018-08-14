using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuilderPattern.Models;
namespace BuilderPattern.Builder
{
    public interface IBuilder
    {
        EmployeeBuilder SetFirstName(string firstname);
        EmployeeBuilder SetLastName(string lastname);
        EmployeeBuilder SetAddress(string address);
        EmployeeBuilder SetTitle(string title);
        EmployeeBuilder SetAge(int age);
        EmployeeBuilder SetDate(DateTime startdate);
        Employee CreateEmployee();
    }
}
