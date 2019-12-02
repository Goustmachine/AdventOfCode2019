using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2019.Days.Day2
{
    public class IntCodeReader
    {
        private readonly List<int> _program;

        public IntCodeReader(List<int> program)
        {
            _program = program;
        }

        public void Run()
        {
            var instructionPointer = 0;
            const int operationDoneIncrement = 4;

            while ((Operation)_program[instructionPointer] != Operation.Terminate)
            {
                var currentValue = _program[instructionPointer];
                if ((Operation) currentValue == Operation.Add)
                {
                    Add(instructionPointer);
                }
                else if ((Operation) currentValue == Operation.Multiply)
                {
                    Multiply(instructionPointer);
                }
                instructionPointer += operationDoneIncrement;
            }
        }

        private void Add(int index)
        {
            var firstIndex = _program[index + 1];
            var secondIndex = _program[index + 2];
            var resultIndex = _program[index + 3];

            _program[resultIndex] = _program[firstIndex] + _program[secondIndex];
        }

        private void Multiply(int index)
        {
            var firstIndex = _program[index + 1];
            var secondIndex = _program[index + 2];
            var resultIndex = _program[index + 3];

            _program[resultIndex] = _program[firstIndex] * _program[secondIndex];
        }

        public List<int> GetProgram()
        {
            return _program;
        }

        public void Replace(int index, int value)
        {
            _program[index] = value;
        }

        public int GetValueAtIndex(int index)
        {
            return _program[index];
        }
    }
}
