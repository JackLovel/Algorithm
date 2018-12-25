using System;

/// <summary>
///  subject: 顺序查找
///  data： 2018/12/15
/// </summary>
namespace Algorithm
{
    class Program
    {     
        private static int OrderSearch(int key, int[] a)
        {
            for (int i = 0; i != a.Length; ++i)
            {
                if (a[i] == key)
                {
                    return a[i];
                }
            }
            return -1;
        }

        static void Main(string[] args)
        {
            int[] whitelist = { 59, 99, 13, 45 };

            Array.Sort(whitelist);

            Console.Write("请输入一个整数：");
            string input = Console.ReadLine();
            int value = Convert.ToInt32(input);

            
            if (OrderSearch(value, whitelist) < 0)  // // if this value is not exist
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
