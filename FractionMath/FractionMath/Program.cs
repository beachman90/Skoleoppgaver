using System.Runtime.CompilerServices;

namespace FractionMath
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fraction exampleHalf = new(1, 2);
            Fraction exampleOneThird = new(1, 3);

            Fraction addNoStaticMethod = exampleHalf.FractureAdd(exampleOneThird);
            Console.WriteLine(addNoStaticMethod.ToText());

            Fraction sumStaticAdd = Fraction.Add(exampleHalf, exampleOneThird);
            Console.WriteLine(sumStaticAdd.ToText());

            Fraction subStaticMethod = exampleHalf.FractureSub(exampleOneThird);
            Console.WriteLine(subStaticMethod.ToText());

            Fraction sumStaticSub = Fraction.Sub(exampleHalf, exampleOneThird);
            Console.WriteLine(sumStaticSub.ToText());
        }

        public class Fraction
        {
            int Numerator { get; set; }
            int Denominator { get; set; }

            public Fraction(int numerator = 0, int denominator = 1)
            {
                Numerator = numerator;
                Denominator = denominator;
            }


            public string ToText()
            {
                return $"{Numerator}/{Denominator}";
            }

            public Fraction FractureAdd(Fraction other)
            {
                int numerator = (Numerator * other.Denominator) + (Denominator * other.Numerator);
                int denominator = Denominator * other.Denominator;
                Fraction sum = new(numerator, denominator);
                return sum;
            }
            public static Fraction Add(Fraction left, Fraction right)
            {
                int numerator = (left.Numerator * right.Denominator) + (left.Denominator * right.Numerator);
                int denominator = left.Denominator * right.Denominator;
                Fraction sum = new(numerator, denominator);
                return sum;
            }

            public Fraction FractureSub(Fraction other)
            {
                int numerator = (Numerator * other.Denominator) - (Denominator * other.Numerator);
                int denominator = Denominator * other.Denominator;
                Fraction sumSub = new(numerator, denominator);
                return sumSub;
            }

            public static Fraction Sub(Fraction left, Fraction right)
            {
                int numerator = (left.Numerator * right.Denominator) - (left.Denominator * right.Numerator);
                int denominator = left.Denominator * right.Denominator;
                Fraction sumSub = new(numerator, denominator);
                return sumSub;

            }

        }





    }


}