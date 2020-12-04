using System;
using System.Collections.ObjectModel;
using System.IO;

namespace AdventOfCode1
{
    class Program
    {

        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines(@"..\..\..\input.txt");
            
            Part1(lines);
            Console.WriteLine("");
            Part2(lines);
        }

        private static void Part1(string[] lines)
        {
            var nombres = new Collection<int>();
            foreach (string line in lines)
            {
                nombres.Add(int.Parse(line));
            }

            var firstNombre = 0;
            var secondNombre = 0;

            foreach (var nombre1 in nombres)
            {
                foreach (var nombre2 in nombres)
                {
                    if (nombre1 == nombre2)
                        continue;
                    if (nombre1 + nombre2 == 2020)
                    {
                        firstNombre = nombre1;
                        secondNombre = nombre2;
                        break;
                    }
                }
            }
            Console.WriteLine($"Part1");
            Console.WriteLine($"1er nombre : {firstNombre}");
            Console.WriteLine($"2ème nombre : {secondNombre}");
            Console.WriteLine($"Somme : {firstNombre + secondNombre}");
            Console.WriteLine($"Multiplication : {(firstNombre * secondNombre).ToString("N")}");
        }

        private static void Part2(string[] lines)
        {
            var nombres = new Collection<int>();
            foreach (string line in lines)
            {
                nombres.Add(int.Parse(line));
            }

            var firstNombre = 0;
            var secondNombre = 0;
            var thirdNombre = 0;

            foreach (var nombre1 in nombres)
            {
                foreach (var nombre2 in nombres)
                {
                    if (nombre1 == nombre2)
                        continue;
                    foreach (var nombre3 in nombres)
                    {
                        if (nombre1 == nombre3)
                            continue;
                        if (nombre2 == nombre3)
                            continue;
                        if (nombre1 + nombre2 + nombre3 == 2020)
                        {
                            firstNombre = nombre1;
                            secondNombre = nombre2;
                            thirdNombre = nombre3;
                            break;
                        }
                    }
                }
            }
            Console.WriteLine("Part2");
            Console.WriteLine($"1er nombre : {firstNombre}");
            Console.WriteLine($"2ème nombre : {secondNombre}");
            Console.WriteLine($"3ème nombre : {thirdNombre}");
            Console.WriteLine($"Somme : {firstNombre + secondNombre + thirdNombre}");
            Console.WriteLine($"Multiplication : {(firstNombre * secondNombre * thirdNombre).ToString("N")}");
        }
    }
}
