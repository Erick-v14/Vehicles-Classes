﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    class Airplane : Vehicle
    {
        public void TakeOff()
        {
            Console.WriteLine("Taking Off");
        }
        public void Land()
        {
            Console.WriteLine("Landing");
        }
        public override void drive()
        {
            Console.WriteLine("Flying");
        }

    }
}
