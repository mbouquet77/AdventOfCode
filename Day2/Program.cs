using System;
using System.IO;

namespace AdventOfCode2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines(@"..\..\..\input.txt");
            var nbValidPasswords = 0;

            Console.WriteLine("Part1");
            foreach (var line in lines)
            {
                string[] tab1 = line.Split('-');
                var nbMinChar = int.Parse(tab1[0]);
                string[] tab2 = tab1[1].Split(' ');
                var nbMaxChar = int.Parse(tab2[0]);
                var charToFind = tab2[1][0];
                var password = tab2[2];

                var nbChar = 0;
                foreach (char c in password)
                {
                    if (c == charToFind)
                        nbChar++;
                }
                if (nbChar < nbMinChar)
                    continue;
                if (nbChar > nbMaxChar)
                    continue;

                nbValidPasswords++;
                Console.WriteLine($"{line}");
            }
            Console.WriteLine($"{nbValidPasswords}");

            nbValidPasswords = 0;

            Console.WriteLine("Part2");
            foreach (var line in lines)
            {
                string[] tab1 = line.Split('-');
                var firstPosition = int.Parse(tab1[0]);
                string[] tab2 = tab1[1].Split(' ');
                var secondPosition = int.Parse(tab2[0]);
                var charToFind = tab2[1][0];
                var password = tab2[2];

                if (password[firstPosition - 1] == charToFind)
                {
                    if (password[secondPosition - 1] == charToFind)
                        continue;
                }
                else
                {
                    if (password[secondPosition - 1] != charToFind)
                        continue;
                }

                nbValidPasswords++;
                Console.WriteLine($"{line}");
            }
            Console.WriteLine($"{nbValidPasswords}");
        }
    }
}
