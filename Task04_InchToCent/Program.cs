using System;

namespace Task04_InchToCent
{
    class Program
    {
        static void Main(string[] args)
        {
            double inch = double.Parse(Console.ReadLine());
            double cent = inch * 2.54;
            Console.WriteLine($"{cent:F2}");
        }
    }
}
