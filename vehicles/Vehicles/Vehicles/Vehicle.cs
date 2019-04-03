using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    class Vehicle
    {
        public void StartEngine (string noisetomakewhenstarting)
        {
            Console.WriteLine($"Starting engine: ");
        }
        public void StopEngine (string noisetomakewhenstopping)
        {
            Console.WriteLine($"Enginge Stopping: ");
        }
        public virtual void drive()            
        {
            Console.WriteLine("Motoring");
        }
    }
}
