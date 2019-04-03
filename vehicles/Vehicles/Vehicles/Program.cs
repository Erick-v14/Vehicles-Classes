using System;

namespace Vehicles
{
    class Program
    {
        static void doWork()
        {
            Console.WriteLine("Journey by airplane");
            Airplane myplane = new Airplane();
            myplane.StartEngine("Contact");
            myplane.TakeOff();
            myplane.drive();
            myplane.Land();
            myplane.StopEngine("Whirr");

            
            Console.WriteLine("\nJourney by Car");
            car myCar = new car();
            myCar.StartEngine("Brm Brm");
            myCar.Accelerate();
            myCar.drive();
            myCar.brake();
            myCar.StopEngine("Whirr");

            Console.WriteLine("\nTesting polymorphism");
            Vehicle v;
                v= myCar;
            v.drive();
             v= myplane;
            v.drive();
        }

        static void Main()
        {
            try
            {
                doWork();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: {0}", ex.Message);
            }
        }
    }
}
