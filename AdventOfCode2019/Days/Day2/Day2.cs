using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdventOfCode2019.Utils;

namespace AdventOfCode2019.Days.Day2
{
    public class Day2
    {
        public static void Run1()
        {
            var fileReader = new FileReader();
            var program = fileReader.ReadAllLinesAsList("Day2");

            var intCodeReader = new IntCodeReader(program);
            intCodeReader.Replace(1, 12);
            intCodeReader.Replace(2, 2);

            intCodeReader.Run();

            Console.WriteLine(intCodeReader.GetValueAtIndex(0));

        }

        public static void Run2()
        {
            const int expectedOutput = 19690720;

            var fileReader = new FileReader();
            for (var i = 0; i < 100; i++)
            {
                for (var j = 0; j < 100; j++)
                {
                    var program = fileReader.ReadAllLinesAsList("Day2");
                    var intCodeReader = new IntCodeReader(program);
                    intCodeReader.Replace(1, i);
                    intCodeReader.Replace(2, j);
                    
                    intCodeReader.Run();

                    var result = intCodeReader.GetValueAtIndex(0);
                    Console.WriteLine($"i:{i}, j:{j}, result: {result}, diff: {expectedOutput - result}");
                    if (result == expectedOutput)
                    {
                        throw new Exception("Value found: " + intCodeReader.GetCombinedNounAndVerb(0));
                    }
                    if (result > expectedOutput)
                    {
                        throw new Exception("Value not found");
                    }
                }
            }
        }
    }
}
