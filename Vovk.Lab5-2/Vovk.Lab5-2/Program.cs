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
            Console.WriteLine("Введите x");
            double x = Convert.ToDouble(Console.ReadLine());
            double S = 0;
            double P = 1;
            int n = 7;
            for (int k = 1; k <= n; k++)
            {
                S+= x * Math.Sin(x) / Math.Pow(k, 3);
                P*= x * Math.Sin(x) / Math.Pow(k, 3);
              
            }
            Console.WriteLine($"Сумма: {S}");
            Console.WriteLine($"Произведение: {P}");
        }
    }
}



        





