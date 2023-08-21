using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refernces
{
    /// <summary>
    ///  Declares the IAutomobile object and tells how fast its going and how many wheels it has and the LicensePlate #
    /// </summary>
    internal interface IAutomobile
    {
        public double Speed { get; }

        public int Wheels { get; }

        public string LicensePlate { get; }

        public void Stringfly();

        
    }
}
