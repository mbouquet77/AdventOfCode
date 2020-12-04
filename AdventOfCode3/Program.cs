using System;

namespace AdventOfCode3
{
    class Program
    {
        static void Main(string[] args)
        {
            var file = @"..\..\..\input.txt";

            var calc = new CalcTreeNumber();

            Console.WriteLine("Part1");
            calc.Part1(file);

            Console.WriteLine("Part2");
            calc.Part2(file);
        }
    }
}
