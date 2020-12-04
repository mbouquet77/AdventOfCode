using AdventOfCodeDay4;
using System;

namespace AdventOffCodeDay4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Part1");

            var file = @"..\..\..\..\input.txt";
            var verifyPassports = new VerifyPassports();

            var nbValidPassports = verifyPassports.CalcNbValidPassports(file, false);

            Console.WriteLine($"nbValidPassports = {nbValidPassports}");

            Console.WriteLine("Part2");

            nbValidPassports = verifyPassports.CalcNbValidPassports(file, true);

            Console.WriteLine($"nbValidPassports with validation = {nbValidPassports}");
        }
    }
}
