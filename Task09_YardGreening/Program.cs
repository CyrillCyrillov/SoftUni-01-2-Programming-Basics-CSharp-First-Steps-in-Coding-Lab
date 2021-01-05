using System;

namespace Task09_YardGreening
{
    class Program
    {
        static void Main(string[] args)
        {
            double yardArea = double.Parse(Console.ReadLine());
            double price = 7.61;
            double discont = 0.18;
            double discontSuma = yardArea * price * discont;
            double suma = (yardArea * price) - discontSuma;
            Console.WriteLine($"The final price is: {suma} lv.");
            Console.WriteLine($"The discont is: {discontSuma} lv.");
        }
    }
}
