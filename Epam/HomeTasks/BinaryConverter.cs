using System;

namespace HomeTasks
{
    public class BinaryConverter
    {
        public int InitialNumber { get; set; }

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

        public void StandartExecute()
        {
            string result = Convert.ToString(InitialNumber, 2).PadLeft(16, '0');
            Console.WriteLine($"Число {InitialNumber} в двоичной системе счислений имеет вид: {result}");
        }
    }
}