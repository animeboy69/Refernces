using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refernces
{
    /// <summary>
    /// Sedan implement the IAutomobile
    /// </summary>
     class Sedan : IAutomobile
    {
        public double Speed { get; private set; }

        public int Wheels { get; private set; }

        public string LicensePlate { get; private set; }

        public Sedan(double speed)
        {
            Wheels = 4;
            Speed = speed;
            LicensePlate = "GCTC-07";
        }

        public void Stringfly()
        {
           Console.WriteLine($"The Sedan is travling at a speed of {Speed} on {Wheels} wheels, with a Lincense Plate # of {LicensePlate}.");
        }

        public void IncreaseSpeed()
        {
            Speed = 5;
        }






       public void DecreaseSpeed()
        {
            Speed -= 5;
        }
    }
}
