using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace leetcode_temp
{
    internal class Program
    {
        static public int[] TwoSum(int[] nums, int target)
        {
            int arrlen = nums.Length;
            int[] values = new int[2];
            bool control = false;
            for (int j = 0; j < arrlen; j++)
            {
                for (int i = j + 1; i < arrlen; i++)
                {
                    if (nums[j] + nums[i] == target)
                    {
                        values[0] = j;
                        values[1] = i;
                        control = true;
                        break;
                    }
                }
                if (control) { break; }
            }
            return values;
        }
        static void Main(string[] args)
        {
            int[] nums = { 3, 2, 4 };
            int target = 6;
            int[] index = new int[2];
            index = TwoSum(nums, target);
            foreach (int temp in index)
            {
                Console.WriteLine(temp);
            }
            Console.ReadLine();
        }
    }
}
