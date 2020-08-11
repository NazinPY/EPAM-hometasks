using System;
using System.Numerics;

namespace HomeTasks
{
    public class NDegreeRoot
    {
        public double InitialNumber { get; set; }
        public int DegreeOfRoot { get; set; }

        private const double ACCURACY = 0.0001;

        public void Execute(double initialNumber = 1)
        {
            double secondLayerBrackets = (1 - InitialNumber / Math.Pow(initialNumber, DegreeOfRoot)) / DegreeOfRoot;
            double firstLayerBrackets = 1 - secondLayerBrackets;
            double result = initialNumber * firstLayerBrackets;

            double checkResult = Math.Pow(result, DegreeOfRoot);

            if (Math.Abs(checkResult - InitialNumber) > ACCURACY)
            {
                Execute(result);
            }
            else
            {
                Console.WriteLine($"Корень {DegreeOfRoot}-й степени из числа {InitialNumber} равен: {result}");
            }
        }
    }
}