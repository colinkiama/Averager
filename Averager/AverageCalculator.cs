using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Averager
{
    public sealed class AverageCalculator
    
    {
        
        /// <summary>
        /// Returns the average from an array of double.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static double GetAverage(params double[] nums)
        {
            double[] numsToAverage = nums.ToArray();
            int n = nums.Count();
            if (n == 0)
            {
                return 0;
            }
            else
            {
                double sum = 0;

                for (int i = 0; i < n; i++)
                {
                    sum += numsToAverage[i];
                }

                double average = sum / n;
                return average;

            }
        }
    }
}

