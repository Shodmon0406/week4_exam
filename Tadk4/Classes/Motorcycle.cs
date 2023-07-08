using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4.Classes
{
    internal class Motorcycle : IVehicle
    {
        public bool IsRunning { get; set; }
        public int Speed { get; set; }

        public void Start()
        {
            IsRunning = true;
            Console.WriteLine("Starting motorcycle engine.");
        }

        public void Stop()
        {
            IsRunning = false;
            Console.WriteLine("Stoping motorcycle engine.");
        }
        public void Drive()
        {
            if (Speed > 0)
            {
                Console.WriteLine("Driving down the road");
                Console.WriteLine($"Driving at {Speed} mph");
            }
            else
            {
                Console.WriteLine("Motorcycle is not driving");
            }
        }
    }
}
