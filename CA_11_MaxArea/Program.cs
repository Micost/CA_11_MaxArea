using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_11_MaxArea
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] h = { 1, 1 };
            Solution s1 = new Solution();
            Console.Write(s1.MaxArea(h));
            var a = Console.ReadKey();
        }
    }
    public class Solution
    {
        public int MaxArea(int[] height)
        {
            int max = 0;
            int low = 0;
            int high = height.Length - 1;
            while (low < high)
            {
                max = Math.Max(max, (high - low) * Math.Min(height[low], height[high]));
                if (height[low]<height[high])
                {
                    low++;
                }
                else
                {
                    high--;
                }
            }
            return max;
        }
    }
}
