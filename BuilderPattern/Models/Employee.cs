using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Models
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Title { get; set; }
        public int Age { get; set; }
        public DateTime StartDate { get; set; }

        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
    }
}
