using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template.Service
{
    /// <summary>
    /// With Senior position
    /// </summary>
    /// <seealso cref="Template.TrainingService" />
    public class SeniorTrainingService : TrainingService
    {
        public override void verity(string appId)
        {
            Console.WriteLine("Test Senior technical ");
        }
        public override void enroll(string candidateName)
        {
            Console.WriteLine("Study Senior");
        }
    }
}
