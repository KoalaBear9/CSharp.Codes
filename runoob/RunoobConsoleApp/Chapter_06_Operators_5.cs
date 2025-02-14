
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
    internal class Chapter_06_Operators_5
    {
        /// 程序的主入口点
        /// </summary>
        /// <param name="args">命令行参数</param>
        /*
        public static void Main(string[] args)
        {
            {
                // sizeof 运算符的实例
                Console.WriteLine("int 的大小是 {0}", sizeof(int));
                Console.WriteLine("short 的大小是 {0}", sizeof(short));
                Console.WriteLine("double 的大小是 {0}", sizeof(double));

                // 三元运算符的实例
                int a, b;
                a = 10;
                b = (a == 1) ? 20 : 30;
                Console.WriteLine("b 的值是 {0}", b);

                b = (a == 10) ? 20 : 30;
                Console.WriteLine("b 的值是 {0}", b);
            }

            {
                Type type = typeof(string);
                Console.WriteLine(type.FullName);
            }

            {
                int a = 20;
                int b = 10;
                int c = 15;
                int d = 5;
                int e;
                e = (a + b) * c / d;     // ( 30 * 15 ) / 5
                Console.WriteLine("(a + b) * c / d 的值是 {0}", e);

                e = ((a + b) * c) / d;   // (30 * 15 ) / 5
                Console.WriteLine("((a + b) * c) / d 的值是 {0}", e);

                e = (a + b) * (c / d);   // (30) * (15/5)
                Console.WriteLine("(a + b) * (c / d) 的值是 {0}", e);

                e = a + (b * c) / d;    //  20 + (150/5)
                Console.WriteLine("a + (b * c) / d 的值是 {0}", e);
            }

            {
                int a = 10, b = 5, c = 2;
                int result = a + b * c;  // 先计算乘法，再计算加法
                Console.WriteLine("a + b * c 的值是 {0}", result);   // 输出20

                result = (a + b) * c;     // 先计算加法，再计算乘法
                Console.WriteLine("(a + b) * c 的值是 {0}", result);   // 输出30

                a += b * c;               // 先计算乘法，再执行加法赋值
                Console.WriteLine("a += b * c 的值是 {0}", a);       // 输出20
            }

            {
                bool a = true, b = false, c = true;
                bool result = a || b && c;  // 先计算与运算，再计算或运算
                Console.WriteLine("a || b && c 的值是 {0}", result);  // 输出true

                result = (a || b) && c;     // 先计算或运算，再计算与运算
                Console.WriteLine("(a || b) && c 的值是 {0}", result);  // 输出true

                result = a || (b && c);     // 先计算与运算，再计算或运算
                Console.WriteLine("a || (b && c) 的值是 {0}", result);  // 输出true
            }

            {
                int a = 10, b = 5;
                string result = a > b ? "a大于b" : "a不大于b";  // 先判断大小关系，再执行条件语句
                Console.WriteLine(result);  // 输出"a大于b"
            }

            {
                int? a = null;
                Console.WriteLine("a 的值是 {0}", a);
            }

            Console.ReadLine();
        }
        */
    }
}