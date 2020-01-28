using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace moshIntermediate
{
    public class Calculator
    {
        public int Add(params int[] numbers)
        {
            var sum = 0;
            foreach(var number in numbers)
            {
                sum += number;
            }
            return sum;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //int.Parse("abc");
            int number;
            var result = int.TryParse("Abc", out number);
            if(result)
                Console.WriteLine(number);
            else
                Console.WriteLine("Conversion Failed");
        }

        static void useParams()
        {
            var calculator = new Calculator();
            Console.WriteLine(calculator.Add(1, 2, 3, 4, 5));
        }

        static void usePoints()
        {
            try
            {
                var point = new Point(10, 20);
                Console.WriteLine("Original Point {0}, {1}: ", point.X, point.Y);
                point.Move(null);
                Console.WriteLine("Point is at {0}, {1}", point.X, point.Y);

                point.Move(100, 200);
                Console.WriteLine("Point moved to {0}, {1}", point.X, point.Y);
            }
            catch (Exception)
            {
                Console.WriteLine("an unexpected occured");
            }
        }
    }
}
