using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2019.Utils
{
    public class FileReader
    {

        public List<string> ReadAllInputLines(string day)
        {
            var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Days", day, "Input", "Input.txt");
            return File.ReadAllLines(path).ToList();
        }
       

        public List<int> ReadAllLinesAsInt(string day)
        {
            return ReadAllInputLines(day).Select(int.Parse).ToList();
        }
    }
}
