using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2019.Days.Day1
{
    public class SpaceCraft
    {
        private readonly List<Module> _modules;
        private readonly FuelCalculator _fuelCalculator;

        public SpaceCraft(List<int> moduleMasses)
        {
            _modules = new List<Module>();
            _fuelCalculator = new FuelCalculator();
            moduleMasses.ForEach(mass => _modules.Add(new Module(mass)));
        }

        public int GetTotalFuelCost()
        {
            return _modules.Sum(x => _fuelCalculator.CalculateFuelRequiredForModule(x.Mass));
        }
    }
}
