using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.IO.Compression;

namespace HomeTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберете дальнейшее действие и нажмите Enter:");
            Console.WriteLine();
            Console.WriteLine("1 - Вычислить корень n-ой степени из числа,");
            Console.WriteLine("2 - Конвертировать число в двоичную систему.");
            Console.WriteLine();
            Console.WriteLine("Для выхода из программы введите \"Exit\"");
            Console.WriteLine();
            string action = "";
            while (!action.ToUpper().Equals("EXIT"))
            {
                action = Console.ReadLine();
                switch (action.ToUpper())
                {
                    case "1":
                        NDegreeRoot root = new NDegreeRoot();
                        break;
                    case "2":
                        BinaryConverter BC = new BinaryConverter();
                        break;
                    case "EXIT":
                        break;
                    default:
                        Console.WriteLine("Вы выбрали неизвестное действие!");
                        break;
                }
            }
        }
    }
}
