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

        private string[] ReadAllInputLines(string day)
        {
            var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Days", day, "Input", "Input.txt");
            return File.ReadAllLines(path);
        }

        private string ReadAllLinesAsString(string day)
        {
            return ReadAllInputLines(day)[0];
        }

        public List<int> ReadAllLinesAsInt(string day)
        {
            return ReadAllInputLines(day).Select(int.Parse).ToList();
        }

        public List<int> ReadAllLinesAsList(string day)
        {
            return ReadAllLinesAsString(day).Split(',').Select(int.Parse).ToList();
        }
    }
}
