using System;

/// <summary>
///  subject: 二分查找
///  data： 2018/11/1
/// </summary>
namespace Algorithm
{
    class Program
    {
        public static int rank(int value, int[] a)
        {
            int lower = 0;
            int hight = a.Length - 1;

            while (lower <= hight)
            {
                int mid = lower + (hight - lower) / 2; // 中间的索引

                if (value < a[mid])
                    hight = mid - 1;
                else if (value > a[mid])
                    lower = mid + 1;
                else
                    return mid;
            }
            return -1; // 如果没有找到该值，就返回 -1;
        }

        static void Main(string[] args)
        {
            int[] whitelist = { 59, 99, 13, 45 };

            Array.Sort(whitelist);

            Console.Write("请输入一个整数：");
            string input = Console.ReadLine();
            int value = Convert.ToInt32(input);

            // 如果输入的值不存在，就打印出这个值
            if (rank(value, whitelist) < 0)
            {
                Console.WriteLine("{0} 这个值不存在", value);

            }
            else
            {
                Console.WriteLine("{0} 这个值存在", value);
            }

            Console.ReadKey();
        }
    }
}

