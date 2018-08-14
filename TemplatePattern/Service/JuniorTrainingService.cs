using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template.Service
{
    /// <summary>
    /// With Junior position
    /// </summary>
    /// <seealso cref="Template.TrainingService" />
    public class JuniorTrainingService:TrainingService
    {
        public override void verity(string appId)
        {
            Console.WriteLine("Test Junior technical");
        }
        public override void enroll(string candidateName)
        {
            Console.WriteLine("Study Junior");
        }
    }
}
