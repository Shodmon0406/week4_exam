using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4.Classes
{
    internal interface IVehicle
    {
        bool IsRunning { get; set; }
        int Speed { get; set; }
        void Start();
        void Stop();
        void Drive();
    }
}
