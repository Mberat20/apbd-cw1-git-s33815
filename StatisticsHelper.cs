using System;

namespace apbd_cw1_git_s33815
{
    public class StatisticsHelper
    {
        public static double CalculateAverage(int[] values)
        {
            if (values == null || values.Length == 0)
                return 0;

            int sum = 0;
            foreach (int number in values)
            {
                sum += number;
            }

            return (double)sum / values.Length;
        }
    }
}