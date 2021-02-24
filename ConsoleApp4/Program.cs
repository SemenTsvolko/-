using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число x:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число y:");
            int y = int.Parse(Console.ReadLine());
            Numbers numbers = new Numbers(x, y);
            numbers.BZ();
            
            Console.ReadKey();
        }
    }
}
