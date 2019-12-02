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
                var instruction = CreateInstruction(instructionPointer);
                if (GetOperation(currentValue) == Operation.Add)
                {
                    _program[instruction.Result] = _program[instruction.Noun] + _program[instruction.Verb];
                }
                else if (GetOperation(currentValue) == Operation.Multiply)
                {
                    _program[instruction.Result] = _program[instruction.Noun] * _program[instruction.Verb];
                }
                instructionPointer += operationDoneIncrement;
            }
        }

        public int GetCombinedNounAndVerb(int instructionPointer)
        {
            var instruction = CreateInstruction(instructionPointer);
            return  100 * instruction.Noun + instruction.Verb;
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

        private Operation GetOperation(int value)
        {
            return (Operation) value;
        }

        private Instruction CreateInstruction(int instructionPointer)
        {
            return new Instruction
            {
                Noun = _program[instructionPointer +1],
                Verb = _program[instructionPointer +2],
                Result = _program[instructionPointer +3]
            };
        }

        private class Instruction
        {
            public int Noun { get; set; }
            public int Verb { get; set; }
            public int Result { get; set; }
        }
    }
}
