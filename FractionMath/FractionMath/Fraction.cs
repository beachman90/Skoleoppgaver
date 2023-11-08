namespace FractionMath
{
    public class Fraction
    {
        public int Numerator { get; set; }
        public int Denominator { get; set; }

        public Fraction(int numerator = 0, int denominator = 1)
        {
            Numerator = numerator;
            Denominator = denominator;
        }


        public override string ToString()
        {
            return $"{Numerator}/{Denominator}";
        }

        public Fraction FractionAdd(Fraction other)
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

        public Fraction FractionSub(Fraction other)
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

        public Fraction FractionMultiply(Fraction other)
        {
            int numerator = Numerator * other.Numerator;
            int denominator = Denominator * other.Denominator;
            Fraction sumMultiply = new(numerator, denominator);
            return sumMultiply;
        }

        public static Fraction Multiply(Fraction left, Fraction right)
        {
            int numerator = left.Numerator * right.Numerator;
            int denominator = left.Denominator * right.Denominator;
            Fraction sumMultiply = new(numerator, denominator);
            return sumMultiply;
        }

        public bool Equals(Fraction other)
        {
            int value1 = Numerator * other.Denominator;
            int value2 = Denominator * other.Numerator;
            bool result = value1 == value2;
            return result;
        }

        public override bool Equals(object? obj)
        {
            if (obj is Fraction other)
            {
                return Equals(other);
            }
            else { return false; }
        }

        //public static FractureAdd operator + (Fraction left, Fraction right)
        //{
        //    return left + right;
        //}
        
    }
}

    
    
    











