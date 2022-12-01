using System;
using System.IO;
using System.Collections.Generic;

namespace AdventOfCode2022
{
    class Program
    {
        static void Main(string[] args)
        {
            string calInput = System.IO.File.ReadAllText("K:/repos/AdventOfCode2022/AdventOfCode2022/Day1/inputD.txt");
            string[] elfCal = calInput.Split(new string[] { "\r\n\r\n" },
                               StringSplitOptions.RemoveEmptyEntries);
            List<int> vals = new List<int>();
            foreach (string strings in elfCal)
            {
                string[] eachCalValue = strings.Split("\r\n");
                int totalVal = 0;
                foreach(string calValue in eachCalValue)
                {
                    totalVal += Convert.ToInt32(calValue);
                }
                vals.Add(totalVal);
            }
            vals.Sort((a, b) => b.CompareTo(a));
            Console.WriteLine(Convert.ToString(vals[0]));
            Console.WriteLine(Convert.ToString(vals[0] + vals[1] + vals[2]));
        }
    }
}
