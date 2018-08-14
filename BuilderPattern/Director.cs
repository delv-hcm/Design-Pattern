using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuilderPattern.Builder;
using BuilderPattern.Models;
namespace BuilderPattern
{
    public class Director
    {
        private IBuilder _Builder;
        public Director(IBuilder Builder)
        {
            _Builder = Builder;
        }
        public Employee CreateEmployee()
        {
            return _Builder.CreateEmployee();
        }
        public Employee GetEmployee()
        {
            return _Builder.CreateEmployee();
        }
    }
}
