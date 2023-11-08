using System.Runtime.CompilerServices;

namespace FractionMath
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            Fraction exampleHalf = new(1, 3);
            Fraction exampleOneThird = new(2, 5);

            Console.WriteLine("Static and non static addition examples:\n");

            Fraction addNoStaticMethod = exampleHalf.FractionAdd(exampleOneThird);
            Console.WriteLine(addNoStaticMethod);

            Fraction sumStaticAdd = Fraction.Add(exampleHalf, exampleOneThird);
            Console.WriteLine(sumStaticAdd);

            Console.WriteLine("\nStatic and non static subtraction examples:\n");

            Fraction subNoStaticMethod = exampleHalf.FractionSub(exampleOneThird);
            Console.WriteLine(subNoStaticMethod);

            Fraction sumStaticSub = Fraction.Sub(exampleHalf, exampleOneThird);
            Console.WriteLine(sumStaticSub);

            Console.WriteLine("\nStatic and non static multiply examples:\n");

            Fraction multiplyNoStaticMethod = exampleHalf.FractionMultiply(exampleOneThird);
            Console.WriteLine(multiplyNoStaticMethod);

            Fraction sumStaticMultiply = Fraction.Multiply(exampleHalf,exampleOneThird);
            Console.WriteLine(sumStaticMultiply);
        }
    }
}






