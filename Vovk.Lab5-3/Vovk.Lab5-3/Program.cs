using System;
namespace Vovk.Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите цифру для удаления");
            int b = Convert.ToInt32(Console.ReadLine());
            int d = 0;
            while (a > 0)
            {
                int c = a % 10;
                if (c != b)
                    d = d * 10 + c;
                a = a / 10;
            }
            while (d > 0)
            {
                a = a * 10 + d % 10;
                d = d / 10; 
            }
            Console.Write(a);
        }
    }
}








