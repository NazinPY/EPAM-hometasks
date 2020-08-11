using System;

namespace HomeTasks
{
    public class BinaryConverter
    {
        /// <summary>
        /// Конвертируемое число
        /// </summary>
        public int InitialNumber { get; set; }

        public BinaryConverter()
        {
            BinaryConverterInit();
        }

        /// <summary>
        /// Метод с запросом числа для конвертиции
        /// </summary>
        private void BinaryConverterInit()
        {
            Console.WriteLine("Введите число:");
            try
            {
                InitialNumber = int.Parse(Console.ReadLine());
                Execute(InitialNumber);
                //binaryConverter.StandartExecute();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// Рекурсивный метод конвертирования десятичного числа в двоичную систему
        /// </summary>
        /// <param name="initialNumber"></param>
        /// <param name="initialString"></param>
        public void Execute(int initialNumber = 0, string initialString = "")
        {
            string convertedNumber = initialString;

            int innerNumber = initialNumber;

            if (innerNumber != 0)
            {
                convertedNumber = (initialNumber % 2).ToString() + convertedNumber;
                innerNumber = initialNumber / 2;
                Execute(innerNumber, convertedNumber);
            }
            else
            {
                Console.WriteLine($"Число {InitialNumber} в двоичной системе счислений имеет вид: {convertedNumber.PadLeft(16,'0')}");
            }
        }

        /// <summary>
        /// Конвертирование десятичного числа в двоичную систему средствами Framework
        /// </summary>
        public void StandartExecute()
        {
            string result = Convert.ToString(InitialNumber, 2).PadLeft(16, '0');
            Console.WriteLine($"Число {InitialNumber} в двоичной системе счислений имеет вид: {result}");
        }
    }
}