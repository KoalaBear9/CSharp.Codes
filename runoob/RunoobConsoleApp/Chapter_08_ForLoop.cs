

using System.Net;

/**
 * 菜鸟教程控制台应用示例
 * 
 * @author  Jason
 * @date    2025-02-11
 */
namespace RunoobConsoleApp
{

    /// <summary>
    /// Chapter_01_Basic_Syntax 类包含了演示C#基本语法的示例代码
    /// </summary>
    internal class Chapter_08_ForLoop
    {
        /// 程序的主入口点
        /// </summary>
        /// <param name="args">命令行参数</param>
        public static void Main(string[] args)
        {
            {
                // for 循环执行
                for (int a = 10; a < 20; a = a + 1)
                {
                    Console.WriteLine("a 的值： {0}", a);
                }
            }

            {
                int[] fibarray = new int[] { 0, 1, 1, 2, 3, 5, 8, 13 };
                foreach (int element in fibarray)
                {
                    Console.WriteLine(element);
                }
                Console.WriteLine();


                // 类似 foreach 循环
                for (int i = 0; i < fibarray.Length; i++)
                {
                    Console.WriteLine(fibarray[i]);
                }
                Console.WriteLine();

                // 设置集合中元素的计算器
                int count = 0;
                foreach (int element in fibarray)
                {
                    count += 1;
                    Console.WriteLine("Element #{0}: {1}", count, element);
                }
                Console.WriteLine("Number of elements in the array: {0}", count);
            }
            Console.ReadLine();
        }
    }
}