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

        }
    }
}
