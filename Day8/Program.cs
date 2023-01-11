using System;
namespace lineComparision
{
    public class Program
    {
        public static void main(double x1, double y1, double x2, double y2)
        {
            double length1, length2;
            if (x1 == x2)//start point equal
            {
                Console.WriteLine(y1.Equals(y2));//check end points are equal
            }
            else
            {
                length1 = x1 - x2;
                length2 = y1 - y2;
                Console.WriteLine(length1.Equals(length2));
                Console.ReadLine();
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("To check Both lines are Equals or no using equals method");
            Console.WriteLine("Enter start and end point of 1 st line ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter start and end point of 2 nd line ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            double y2 = Convert.ToDouble(Console.ReadLine());
            Program.main(x1, y1, x2, y2);

        }
    }
}
