using System;

namespace Vovk.Lab5
{
    class Program
    {
        static double Func(double x, double k)
        {
            double F = (x * Math.Sin(x))/Math.Pow(k,3);
            return F;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Циклы на выбор: for,while,do/while");
            string cucle = Convert.ToString(Console.ReadLine());
            switch (cucle)
            {
                case "for":
                    for (double x = 0; x < 1;  x=x + 0.1) ;
                    {
                        for (double k = 1; k < 1.2; k=k + 0.1) ;
                        {
                            Console.WriteLine();
                        }
                    }
                    break;
                case "while":
                    double n = 0;
                    while (n < 1) ;
                    {
                        double m = 1;
                        {
                            while (m < 1.2) ;
                            Console.WriteLine($"{Func(n, m) }");
                          m=  m + 0.1;
                        }
                       n= n + 0.1;
                    }
                    break;
                case "do/while":
                    double z = 0;
                    do
                    {
                        double c = 1;
                        do
                        {
                            Console.WriteLine($"{Func(z, c) }");
                            c=c + 0.1;
                        }
                        while (c < 1.2);
                        z=z + 0.1;
                    }
                    while (z < 1);
                    break;
            }
        }
    }
}

























