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

        public void Multiply_TwoFraction_ReturnsExpectedSum()
        {
            Fraction fraction = new(2, 5);
            Fraction fraction2 = new(2, 7);

            Fraction expected = new(4, 35);

            Fraction actual = fraction.FractionMultiply(fraction2);

            Assert.That(actual, Is.EqualTo(expected));
        }



        
    }
}