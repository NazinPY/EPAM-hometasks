using System;
using System.Numerics;

namespace HomeTasks
{
    public class NDegreeRoot
    {
        /// <summary>
        /// Число из которого будет извлечен корень n-й степени
        /// </summary>
        public double InitialNumber { get; set; }

        /// <summary>
        /// Значение степени корня
        /// </summary>
        public int DegreeOfRoot { get; set; }

        private const double ACCURACY = 0.0001;

        public NDegreeRoot()
        {
            NDegreeRootInit();
        }

        /// <summary>
        /// Метод с запросом параметров расчета
        /// </summary>
        private void NDegreeRootInit()
        {
            Console.WriteLine("Введите число и степень корня:");
            try
            {
                InitialNumber = double.Parse(Console.ReadLine());
                DegreeOfRoot = int.Parse(Console.ReadLine());
                Execute();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// Метод извлечения корня n-й степени из числа, основанный на методе Ньютона
        /// с выводом конечно результата
        /// </summary>
        /// <param name="initialNumber"></param>
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