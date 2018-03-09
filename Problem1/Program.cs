using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double density = double.Parse(Console.ReadLine());
            double sum = 0.0;

            for (int i = 0; i < n; i++)
            {
                double[] nums = Console.ReadLine().Split().Select(double.Parse).ToArray();

                double raindropsCount = nums[0];
                double squareMeters = nums[1];
                sum += raindropsCount / squareMeters;
            }

            if (sum != 0 && density != 0)
            {
                double totalSum = sum / density;
                Console.WriteLine("{0:f3}", totalSum);
            }
            else
            {
                Console.WriteLine("{0:f3}", sum);
            }
        }
    }
}
