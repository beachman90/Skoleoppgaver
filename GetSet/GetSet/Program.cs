namespace GetSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Square mySquare = new(int.Parse(Console.ReadLine()));
            Console.WriteLine(mySquare.CalculateArea());
            Console.WriteLine(mySquare.CalculateOmkrets());

            Square newSquare = new(5);
            Console.WriteLine(newSquare.CalculateOmkrets());

            Square anotherSquare = new();
            anotherSquare.SetLength(12);
            Console.WriteLine(anotherSquare.CalculateArea());
        }
    }

    class Square
    {
        private int _length;
       
        public Square()
        {

        }
        public Square(int length)
        {
            _length = length;
        }
        public int GetLength()
        {
            return _length;
        }

        public void SetLength(int length)
        {
            if (length <= 0)
            {
                _length = 1;
            }
            else
            {
                _length = length;
            }
        }

        public int CalculateArea()
        {
            return _length * _length;
        }

        public int CalculateOmkrets()
        {
            return _length * 4;
        }


    }
}