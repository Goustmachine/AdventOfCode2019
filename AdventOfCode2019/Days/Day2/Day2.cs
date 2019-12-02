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
            var programLength = fileReader.ReadAllLinesAsList("Day2").Count;
            var done = false;
            for (var i = 0; i < programLength; i++)
            {
                for (var j = 0; j < programLength; j++)
                {
                    var program = fileReader.ReadAllLinesAsList("Day2");
                    var intCodeReader = new IntCodeReader(program);
                    intCodeReader.Replace(1, i);
                    intCodeReader.Replace(2, j);
                    
                    intCodeReader.Run();

                    var result = intCodeReader.GetValueAtIndex(0);
                    if (result == expectedOutput)
                    {
                        Console.WriteLine("Value found: " + intCodeReader.GetCombinedNounAndVerb(0));
                        done = true;
                    }
                    else if (result > expectedOutput)
                    {
                        Console.WriteLine("Value not found");
                        done = true;
                    }

                    if (done)
                    {
                        break;
                    }
                }

                if (done)
                {
                    break;
                }
            }
        }
    }
}
