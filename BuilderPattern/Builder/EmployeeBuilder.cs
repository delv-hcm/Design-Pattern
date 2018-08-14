using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuilderPattern.Models;
namespace BuilderPattern.Builder
{
 public   class EmployeeBuilder:IBuilder
    {
        private Employee emp = new Employee();

        public EmployeeBuilder SetAddress(string address)
        {
            emp.Address = address;
            return this;
        }

        public EmployeeBuilder SetAge(int age)
        {
            emp.Age = age;
            return this;
        }

        public EmployeeBuilder SetDate(DateTime startdate)
        {
            emp.StartDate = startdate;
            return this;
        }

        public EmployeeBuilder SetFirstName(string firstname)
        {
            emp.FirstName = firstname;
            return this;
        }

        public EmployeeBuilder SetLastName(string lastname)
        {
            emp.LastName = lastname;
            return this;
        }

        public EmployeeBuilder SetTitle(string title)
        {
            emp.Title = title;
            return this;
        }
        public Employee CreateEmployee()
        {
            return emp;
        }
    }
}
