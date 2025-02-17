

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
    internal class Chapter_08_Loops_2
    {
        static int k = 50;
        decimal[] feiBos = new decimal[k];
        decimal feiBo(int a)
        {
            if (a <= 1)
            {
                return a;
            }
            if (feiBos[a] != 0)
            {
                return feiBos[a];
            }
            return feiBos[a] = feiBo(a - 1) + feiBo(a - 2);
        }


        /// 程序的主入口点
        /// </summary>
        /// <param name="args">命令行参数</param>
        public static void Main(string[] args)
        {
            {
                Chapter_08_Loops_2 feiBo = new Chapter_08_Loops_2();
                for (int n = k - 1; n >= 0; n--)
                {
                    Console.WriteLine(feiBo.feiBo(n));
                }
            }

            Console.ReadLine();
        }
    }
}