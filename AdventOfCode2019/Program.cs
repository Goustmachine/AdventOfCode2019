using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdventOfCode2019.Days.Day1;
using AdventOfCode2019.Utils;

namespace AdventOfCode2019
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var fileReader = new FileReader();
            var moduleMasses = fileReader.ReadAllLinesAsInt("Day1");
            var spaceCraft = new SpaceCraft(moduleMasses);

            Console.WriteLine(spaceCraft.GetTotalFuelCost());


            Console.Read();
        }
    }
}
