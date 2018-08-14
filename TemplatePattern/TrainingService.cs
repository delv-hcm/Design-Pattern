using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template
{
    /// <summary>
    /// All candicate person have to follow this service
    /// </summary>
    public abstract class TrainingService
    {
        public void apply()
        {
            Console.WriteLine("Apply..");
        }
        public abstract void verity(string appId);
        public abstract void enroll(string candidateName);
        public void register(string appId, string candidateName)
        {
            apply();
            verity(appId);
            enroll(candidateName);
        }
    }
}
