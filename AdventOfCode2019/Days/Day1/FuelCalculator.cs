using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2019.Days.Day1
{
    public class FuelCalculator
    {
        public int CalculateFuelRequired(double moduleMass)
        {
            return (int) Math.Floor(moduleMass / 3) -2;
        }

        public int CalculateFuelRequiredForModule(double moduleMass)
        {
            var fuelRequired = CalculateFuelRequired(moduleMass);

            if (fuelRequired <= 0)
            {
                return 0;
            }

            return fuelRequired + CalculateFuelRequiredForModule(fuelRequired);
        }
    }
}
