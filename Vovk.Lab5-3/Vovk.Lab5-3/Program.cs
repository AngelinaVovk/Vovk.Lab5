using System;
namespace Vovk.Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            string str = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Введите цифру для удаления");
            string y = Convert.ToString(Console.ReadLine());
            switch (y)
            {
                case "0":
                    {
                        Console.WriteLine("Результат : " + str.Replace("0", ""));
                    }
                    break;

                case "1":
                    {
                        Console.WriteLine("Результат : " + str.Replace("1", ""));
                    }
                    break;
                case "2":
                    {
                        Console.WriteLine("Результат : " + str.Replace("2", ""));
                    }
                    break;
                case "3":
                    {
                        Console.WriteLine("Результат : " + str.Replace("3", ""));
                    }
                    break;
                case "4":
                    {
                        Console.WriteLine("Результат : " + str.Replace("4", ""));
                    }
                    break;
                case "5":
                    {
                        Console.WriteLine("Результат : " + str.Replace("5", ""));
                    }
                    break;
                case "6":
                    {
                        Console.WriteLine("Результат : " + str.Replace("6", ""));
                    }
                    break;
                case "7":
                    {
                        Console.WriteLine("Результат : " + str.Replace("7", ""));
                    }
                    break;
                case "8":
                    {
                        Console.WriteLine("Результат : " + str.Replace("8", ""));
                    }
                    break;
                case "9":
                    {
                        Console.WriteLine("Результат : " + str.Replace("9", ""));
                    }
                    break;
            }
        }
    }
}








