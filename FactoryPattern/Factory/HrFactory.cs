
using Factory.Model;
namespace Factory.Factory
{
    public class HrFactory
    {
        public Employee GetType(string type)
        {
            switch (type)
            {
                case "Manager":
                    return new Manager();
                case "Programer":
                    return new Programer();
                case "Tester":
                    return new Tester();

            }
            return null;
        }
    }
}
