using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdventOfCode2019.Utils;

namespace AdventOfCode2019.Days.Day1
{
    public class Day1
    {
        public static void Run()
        {
            var fileReader = new FileReader();
            var moduleMasses = fileReader.ReadAllLinesAsInt("Day1");
            var spaceCraft = new SpaceCraft(moduleMasses);

            Console.WriteLine(spaceCraft.GetTotalFuelCost());

        }
    }
}
