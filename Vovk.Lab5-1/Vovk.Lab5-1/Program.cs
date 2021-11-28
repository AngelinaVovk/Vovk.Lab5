using System;

namespace Vovk.Lab5
{
    class Program
    {
        static double Function(double x, double k)
        {

            double F = (x * Math.Sin(x)) / Math.Pow(k, 3);
            return F;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите цикл: for,while, do-while ");
            try
            {
                string cycle = Console.ReadLine();

                switch (cycle)
                {
                    case "for":
                        for (double x = 0; x < 1; x = x + 0.1)
                        {
                            for (double k = 1; k < 1.2; k = k + 0.1)
                            {
                                double t = Function(x, k);
                                Console.Write($"{Math.Round(t, 5)}\t");

                            }
                            Console.WriteLine();

                        }
                        break;

                    case "while":
                        double n = 0;
                        while (n < 11)
                        {
                            double m = 1;
                            while (m < 1)
                            {
                                double t = Function(n, m);
                                Console.Write($"{Math.Round(t, 5)}\t");
                                m = m + 0.1;

                            }
                            Console.WriteLine();
                            n = n + 0.1;
                        }
                        break;

                    case "do-while":
                        double z = 0;
                        do
                        {
                            double c = 1;
                            do
                            {
                                double t = Function(z, c);
                                Console.Write($"{Math.Round(t, 5)}\t");
                                c = c + 0.1;
                            }

                            while (z < 1);
                            Console.WriteLine();
                            z = z + 0.1;
                        }
                        while (z < 1);

                        break;
                }

            }
            catch (Exception)
            {
                Console.WriteLine("Exception");
            }

        }
    }
}

























