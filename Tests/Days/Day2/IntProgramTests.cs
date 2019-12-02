using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdventOfCode2019.Days.Day2;
using Xunit;

namespace Tests.Days.Day2
{
    public class IntProgramTests
    {
        private List<int> _program;
        private IntCodeReader _intCodeReader;

        [Fact]
        public void CanHandleSimpleAdditionProgram()
        {
            _program = CreateProgram(1,0,0,0,99);
            _intCodeReader = new IntCodeReader(_program);
            var expected = CreateProgram( 2, 0, 0, 0, 99 );

            _intCodeReader.Run();
            var actual = _intCodeReader.GetProgram();

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void CanHandleSimpleMultiplicationProgram()
        {
            _program = CreateProgram(2, 3, 0, 3, 99);
            _intCodeReader = new IntCodeReader(_program);
            var expected = CreateProgram(2, 3, 0, 6, 99);

            _intCodeReader.Run();
            var actual = _intCodeReader.GetProgram();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CanHandleLongerProgram()
        {
            _program = CreateProgram(2, 4, 4, 5, 99, 0);
            _intCodeReader = new IntCodeReader(_program);
            var expected = CreateProgram(2, 4, 4, 5, 99, 9801);

            _intCodeReader.Run();
            var actual = _intCodeReader.GetProgram();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CanHandleLongProgram()
        {
            _program = CreateProgram(1, 1, 1, 4, 99, 5, 6, 0, 99);
            _intCodeReader = new IntCodeReader(_program);
            var expected = CreateProgram(30, 1, 1, 4, 2, 5, 6, 0, 99);

            _intCodeReader.Run();
            var actual = _intCodeReader.GetProgram();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CanSwitchValuesInProgram()
        {
            _program = CreateProgram(2, 3, 0, 3, 99);
            _intCodeReader = new IntCodeReader(_program);
            var expected = CreateProgram(5, 3, 10, 3, 99);

            _intCodeReader.Replace(0, 5);
            _intCodeReader.Replace(2, 10);
            var actual = _intCodeReader.GetProgram();

            Assert.Equal(expected, actual);
        }

        private List<int> CreateProgram(params int[] values)
        {
            return values.ToList();
        }
    }
}
