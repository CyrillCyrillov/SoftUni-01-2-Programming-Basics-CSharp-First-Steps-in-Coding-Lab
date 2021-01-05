using System;

namespace Task_08_PetShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int dogs = int.Parse(Console.ReadLine());
            int allRest = int.Parse(Console.ReadLine());
            double dogPrice = 2.50;
            double allRestPrice = 4;
            double suma = dogs * dogPrice + allRest * allRestPrice;
            Console.WriteLine($"{suma} lv.");
        }
    }
}
