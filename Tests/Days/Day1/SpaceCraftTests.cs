using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdventOfCode2019.Days.Day1;
using Xunit;

namespace Tests.Days.Day1
{
    public class SpaceCraftTests
    {
        private SpaceCraft _spaceCraft;

        [Fact]
        public void CanCalculateTotalSumOfModuleFuel()
        {
            var moduleMasses = new List<int>(){12, 14, 12, 14};
            _spaceCraft = new SpaceCraft(moduleMasses);

            const int expected = 8;

            Assert.Equal(expected, _spaceCraft.GetTotalFuelCost());
        }
    }
}
