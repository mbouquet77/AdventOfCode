using AdventOfCode3;
using Xunit;
using NFluent;

namespace AdventOfCode3Tests
{
    public class NbTreesTests
    {
        private readonly CalcTreeNumber _prog;
        private readonly string _file;

        public NbTreesTests()
        {
            _prog = new CalcTreeNumber();
            _file = @"D:\Perso\Advent of code\AdventOfCode3\exemple.txt";
        }
        [Fact]
        public void Part1CorrectNbTrees()
        {
            var nbTrees = _prog.Part1(_file);

            Check.That(nbTrees).IsEqualTo(7);
        }
        [Fact]
        public void Part2CorrectNbTreesMultiplied()
        {
            var nbTreesMultiplied = _prog.Part2(_file);

            Check.That(nbTreesMultiplied).IsEqualTo(336);
        }
    }
}
