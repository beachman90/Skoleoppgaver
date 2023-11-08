using System.Security.Cryptography.X509Certificates;

namespace FractionMath.UnitTesting
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Add_TwoFraction_ReturnsExpectedSum()
        {
            Fraction fraction = new(1, 4);
            Fraction fraction2 = new(2, 4);

            Fraction expected = new(12, 16);

            Fraction actual = fraction.FractionAdd(fraction2);

            Assert.That(actual, Is.EqualTo(expected));


        }

        
    }
}