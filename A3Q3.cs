using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3rd
{
    internal class MathHelper
    {
        public static double CalculateAverage(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                throw new ArgumentException("Array cannot be null or empty.");
            }

            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }

            return (double)sum / numbers.Length;
        }
    }
       public static void average()
        {
            // Example usage of the MathHelper class
            int[] numbers = { 10, 20, 30, 40, 50 };

            try
            {
                double average = MathHelper.CalculateAverage(numbers);
                Console.WriteLine($"The average is: {average}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}