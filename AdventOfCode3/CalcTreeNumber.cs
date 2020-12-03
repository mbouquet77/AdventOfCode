using System;
using System.IO;
using System.Linq;

namespace AdventOfCode3
{
    public class CalcTreeNumber
    {
        public int CalcNbTrees(string file, int deplacementLigne, int deplacementColonne)
        {
            var lines = File.ReadAllLines(file).ToArray();

            var newLine = 0;
            var newColonne = 0;
            var nbTrees = 0;

            newLine += deplacementLigne;
            newColonne += deplacementColonne;
            while (lines.Count() > newLine)
            {
                var line = lines[newLine];
                while (line.Length <= newColonne)
                    line += line;

                var position = line[newColonne];
                if (position == '#')
                    nbTrees++;

                newLine += deplacementLigne;
                newColonne += deplacementColonne;
            }
            return nbTrees;
        }

        public int Part1(string file)
        {
            int nbTrees = CalcNbTrees(file, 1, 3);
            Console.WriteLine($"déplacement 1-3 : nb arbres = {nbTrees}");

            return nbTrees;
        }

        public Int64 Part2(string file)
        {
            Int64 nbTrees1 = CalcNbTrees(file, 1, 1);
            Console.WriteLine($"déplacement 1-1 : nb arbres = {nbTrees1}");

            Int64 nbTrees2 = CalcNbTrees(file, 1, 3);
            Console.WriteLine($"déplacement 1-3 : nb arbres = {nbTrees2}");

            Int64 nbTrees3 = CalcNbTrees(file, 1, 5);
            Console.WriteLine($"déplacement 1-5 : nb arbres = {nbTrees3}");

            Int64 nbTrees4 = CalcNbTrees(file, 1, 7);
            Console.WriteLine($"déplacement 1-7 : nb arbres = {nbTrees4}");

            Int64 nbTrees5 = CalcNbTrees(file, 2, 1);
            Console.WriteLine($"déplacement 2-1 : nb arbres = {nbTrees5}");

            Int64 nbTreesMultiplied = nbTrees1 * nbTrees2 * nbTrees3 * nbTrees4 * nbTrees5;
            Console.WriteLine($"nbTreesMultiplied = {nbTreesMultiplied.ToString("N")}");
            return nbTreesMultiplied;
        }    
    }
}
