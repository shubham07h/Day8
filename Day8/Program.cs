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
                double compare = y1.CompareTo(y2);
                if (compare == 0)
                {
                    Console.WriteLine("Both Lines are Equals");
                }
                else if (compare >= 0)
                {
                    Console.WriteLine("2nd line is smaller than 1 st");
                }
                else
                {
                    Console.WriteLine("1st line is smaller than 2nd");
                }
            }
            else
            {
                length1 = x1 - x2;
                length2 = y1 - y2;
                double compare = length1.CompareTo(length2);
                if (compare == 0)
                {
                    Console.WriteLine("Both Lines are Equals");
                }
                else if (compare >= 0)
                {
                    Console.WriteLine("2nd line is smaller than 1 st");
                }
                else
                {
                    Console.WriteLine("1st line is smaller than 2nd");
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("To Compare Both Line using CompareTo method");
            Console.WriteLine("Enter 1 st line coordinates ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter 2 nd line coordinates ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            double y2 = Convert.ToDouble(Console.ReadLine());
            Program.main(x1, y1, x2, y2);

        }
    }
}
