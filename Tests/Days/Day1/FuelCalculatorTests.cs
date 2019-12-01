using AdventOfCode2019.Days.Day1;
using Xunit;

namespace Tests.Days.Day1
{
    public class FuelCalculatorTests
    {
        private readonly FuelCalculator _fuelCalculator;

        public FuelCalculatorTests()
        {
            _fuelCalculator = new FuelCalculator();
        }

        [Fact]
        public void CalculatesSimpleFuelAmount()
        {
            var module = new Module(12);

            const int expectedFuel = 2;

            Assert.Equal(expectedFuel, _fuelCalculator.CalculateFuelRequired(module.Mass));
        }

        [Fact]
        public void CalculatesNoFuelAmount()
        {
            var module = new Module(1);

            const int expectedFuel = -2;

            Assert.Equal(expectedFuel, _fuelCalculator.CalculateFuelRequired(module.Mass));
        }

        [Fact]
        public void CalculatesAnotherSimpleFuelAmount()
        {
            var module = new Module(14);

            const int expectedFuel = 2;

            Assert.Equal(expectedFuel, _fuelCalculator.CalculateFuelRequired(module.Mass));
        }

        [Fact]
        public void CalculatesBigModuleFuelAmount()
        {
            var module = new Module(1969);

            const int expectedFuel = 654;

            Assert.Equal(expectedFuel, _fuelCalculator.CalculateFuelRequired(module.Mass));
        }

        [Fact]
        public void CalculatesHugeModuleFuelAmount()
        {
            var module = new Module(100756);

            const int expectedFuel = 33583;

            Assert.Equal(expectedFuel, _fuelCalculator.CalculateFuelRequired(module.Mass));
        }

        [Fact]
        public void CalculatesSmallMassFuelRequiringFuel()
        {
            var module = new Module(14);

            const int expectedFuel = 2;

            Assert.Equal(expectedFuel, _fuelCalculator.CalculateFuelRequiredForModule(module.Mass));
        }

        [Fact]
        public void CalculatesLargeMassFuelRequiringFuel()
        {
            var module = new Module(1969);

            const int expectedFuel = 966;

            Assert.Equal(expectedFuel, _fuelCalculator.CalculateFuelRequiredForModule(module.Mass));
        }

        [Fact]
        public void CalculatesHugeMassFuelRequiringFuel()
        {
            var module = new Module(100756);

            const int expectedFuel = 50346;

            Assert.Equal(expectedFuel, _fuelCalculator.CalculateFuelRequiredForModule(module.Mass));
        }
    }
}
