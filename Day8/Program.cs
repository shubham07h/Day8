using System;
namespace lineComparision
{
    public class Program
    {
        public static void main(double x1, double x2, double y1, double y2)
        {
            Console.WriteLine("Welcome to Line Comparison Computation Program");
            double sum, length;
            sum = ((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            length = Math.Sqrt(sum);
            Console.WriteLine("length of Line - " + length);
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1st coordinates ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter 2nd coordinates ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            double y2 = Convert.ToDouble(Console.ReadLine());
            Program.main(x1, y1, x2, y2);
        }
    }
}
