using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Template.Service;
namespace Template
{
    class Program
    {
        static void Main(string[] args)
        {
            TrainingService service = new JuniorTrainingService();
            service.register("01","Delv1");
            service = new SeniorTrainingService();
            service.register("02", "DelV2");
            Console.ReadKey();

        }
    }
}
