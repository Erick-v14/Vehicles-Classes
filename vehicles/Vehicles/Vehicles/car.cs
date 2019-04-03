using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    class car : Vehicle
    {
        public void Accelerate()
        {
            Console.WriteLine("Accelerate");
        }
        public void brake()
        {
            Console.WriteLine("Brake!");
        }
        public override void drive()
        {
            Console.WriteLine("Motoring");
        }

    }
}
