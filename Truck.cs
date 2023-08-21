using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refernces
{
    /// <summary>
    ///  This tells everything what the Truck is doing and tells the speed and tells how much wheels it has and the licnseplate and the weight
    /// </summary>
    class Truck : IAutomobile
    {
        public double Speed { get; private set; }

        public int Wheels {get; private set; }

        public string LicensePlate {get; private set; }

        public double Weight { get; }

        public Truck(double speedParam, double weightParam, string licenseNum)
        {
            Speed = speedParam;
           Weight = weightParam;
            LicensePlate = licenseNum;
            
                if(Weight < 400)
            {
                Wheels = 9;
            }
            else
            {
                Wheels = 13;
            }
        }

        /// <summary>
        ///  Tells what the Truck is doing and how fast its going and the LicensePlate number
        /// </summary>

        public void Stringfly()
        {
            Console.WriteLine($"The Truck is traveling at a speed of {Speed} on {Wheels} wheels, with a License Plate # of {LicensePlate}! ");
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
