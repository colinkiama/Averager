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
        public static double GetAverage(IEnumerable<double> nums)
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

