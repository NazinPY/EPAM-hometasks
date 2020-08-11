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
                        nDegreeRootInit();
                        break;
                    case "2":
                        binaryConverterInit();
                        break;
                    case "EXIT":
                        break;
                    default:
                        Console.WriteLine("Вы выбрали неизвестное действие!");
                        break;
                }
            }
        }

        private static void nDegreeRootInit()
        {
            NDegreeRoot root = new NDegreeRoot();
            Console.WriteLine("Введите число и степень корня:");
            try
            {
                root.InitialNumber = double.Parse(Console.ReadLine());
                root.DegreeOfRoot = int.Parse(Console.ReadLine());
                root.Execute();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void binaryConverterInit()
        {
            BinaryConverter binaryConverter = new BinaryConverter();
            Console.WriteLine("Введите число:");
            try
            {
                binaryConverter.InitialNumber = int.Parse(Console.ReadLine());
                binaryConverter.Execute(binaryConverter.InitialNumber);
                //binaryConverter.StandartExecute();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
