using System;
namespace Vovk.Lab5
{
    class Program
    {
        static double Func(double x, double k)
        {
            double F = (x * Math.Sin(x)) / Math.Pow(k, 3);
            return F;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите числовой ряд");
            Console.WriteLine("Расчет суммы ряда");
            double S = 0;
            double x = Convert.ToDouble(Console.ReadLine());
            for (int k = 1; k < 7; k++)
            {
                double F = Func(x, k);
                S += F;
                Console.WriteLine(S);
            }
            Console.WriteLine("Расчет произведения ряда");
            for (int k = 1; k < 7; k++)
            {
                double F = Func(x, k);
                S *= F;
                Console.WriteLine(S);
            }
        }
    }
}



        





