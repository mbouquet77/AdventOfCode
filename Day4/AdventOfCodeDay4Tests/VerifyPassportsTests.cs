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
            var file = @"..\..\..\..\exemple.txt";
            var nbValidPassports = _verifyPassports.CalcNbValidPassports(file, false);

            Check.That(nbValidPassports).IsEqualTo(2);
        }

        [Fact]
        public void VerifyValidPassportsWithValidation()
        {
            var file = @"..\..\..\..\validPassports.txt";
            var nbValidPassports = _verifyPassports.CalcNbValidPassports(file, true);

            Check.That(nbValidPassports).IsEqualTo(4);
        }

        [Fact]
        public void VerifyInvalidPassportsWithValidation()
        {
            var file = @"..\..\..\..\invalidPassports.txt";
            var nbValidPassports = _verifyPassports.CalcNbValidPassports(file, true);

            Check.That(nbValidPassports).IsEqualTo(0);
        }
    }
}
