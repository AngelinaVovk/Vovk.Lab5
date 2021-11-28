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
                    for (int i = 0; i < 2; i++) ;
                    {
                        Console.WriteLine("Результат : " + str.Replace("0", ""));
                    }
                    break;

                case "1":
                    for (int i = 1; i < 2; i++) ;
                    {
                        Console.WriteLine("Результат : " + str.Replace("1", ""));
                    }
                    break;
                case "2":
                    for (int i = 2; i < 2; i++) ;
                    {
                        Console.WriteLine("Результат : " + str.Replace("2", ""));
                    }
                    break;
                case "3":
                    for (int i = 3; i < 2; i++) ;
                    {
                        Console.WriteLine("Результат : " + str.Replace("3", ""));
                    }
                    break;
                case "4":
                    for (int i = 4; i < 2; i++) ;
                    {
                        Console.WriteLine("Результат : " + str.Replace("4", ""));
                    }
                    break;
                case "5":
                    for (int i = 5; i < 2; i++) ;
                    {
                        Console.WriteLine("Результат : " + str.Replace("5", ""));
                    }
                    break;
                case "6":
                    for (int i = 6; i < 2; i++) ;
                    {
                        Console.WriteLine("Результат : " + str.Replace("6", ""));
                    }
                    break;
                case "7":
                    for (int i = 7; i < 2; i++) ;
                    {
                        Console.WriteLine("Результат : " + str.Replace("7", ""));
                    }
                    break;
                case "8":
                    for (int i = 8; i < 2; i++) ;
                    {
                        Console.WriteLine("Результат : " + str.Replace("8", ""));
                    }
                    break;
                case "9":
                    for (int i = 9; i < 2; i++) ;
                    {
                        Console.WriteLine("Результат : " + str.Replace("9", ""));
                    }
                    break;
            }
        }
    }
}








