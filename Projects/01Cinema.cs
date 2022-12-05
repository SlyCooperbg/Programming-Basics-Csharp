using System;

namespace _01Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pjctType = Console.ReadLine();
            int r = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            switch (pjctType)
            {
                case "Premiere":
                    Console.WriteLine("{0:F2}", r * c * 12);
                    break;
                case "Normal":
                    Console.WriteLine("{0:F2}", r * c * 7.5);
                    break;
                case "Discount":
                    Console.WriteLine("{0:F2}", r * c * 5);
                    break;
            }
        }
    }
}
