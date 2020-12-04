using AdventOfCodeDay4;
using Xunit;
using NFluent;

namespace AdventOfCodeDay4Tests
{
    public class VerifyPassportsTests
    {
        private readonly VerifyPassports _verifyPassports;

        public VerifyPassportsTests()
        {
            _verifyPassports = new VerifyPassports();
        }

        [Fact]
        public void VerifyNbValidPassports()
        {
            var file = @"D:\Perso\Advent of code\Day4\exemple.txt";
            var nbValidPassports = _verifyPassports.CalcNbValidPassports(file, false);

            Check.That(nbValidPassports).IsEqualTo(2);
        }

        [Fact]
        public void VerifyValidPassportsWithValidation()
        {
            var file = @"D:\Perso\Advent of code\Day4\validPassports.txt";
            var nbValidPassports = _verifyPassports.CalcNbValidPassports(file, true);

            Check.That(nbValidPassports).IsEqualTo(4);
        }

        [Fact]
        public void VerifyInvalidPassportsWithValidation()
        {
            var file = @"D:\Perso\Advent of code\Day4\invalidPassports.txt";
            var nbValidPassports = _verifyPassports.CalcNbValidPassports(file, true);

            Check.That(nbValidPassports).IsEqualTo(0);
        }
    }
}
