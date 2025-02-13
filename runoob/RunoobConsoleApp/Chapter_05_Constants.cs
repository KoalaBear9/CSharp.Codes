
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
    internal class Chapter_05_Constants
    {
        /// 程序的主入口点
        /// </summary>
        /// <param name="args">命令行参数</param>
        /*
        public static void Main(string[] args)
        {
            SampleClass sample = new SampleClass(11, 22);
            Console.WriteLine("x = {0}, y = {1}", sample.x, sample.y);
            Console.WriteLine("c1 = {0}, c2 = {1}", SampleClass.c1, SampleClass.c2);

            // string testValue = "0.2";
            string testValue = null;
            // string testValue = "";
            try
            {
                double doubleValue1 = double.Parse(testValue); // 需加非空判断在进行类型转换
            }
            catch (Exception e)
            {
                Console.WriteLine("doubleValue1转换出错:" + e.Message);
            }
            try
            {
                double doubleValue2 = Convert.ToDouble(testValue);
            }
            catch (Exception e)
            {
                Console.WriteLine("doubleValue2转换出错:" + e.Message);
            }
            try
            {
                double doubleValue3;
                double.TryParse(testValue, out doubleValue3);
            }
            catch (Exception e)
            {
                Console.WriteLine("doubleValue3转换出错:" + e.Message);
            }
        }
        */
    }

    /// <summary>
    /// 示例类
    /// </summary>
    internal class SampleClass
    {
        public int x;
        public int y;
        public const int c1 = 5;
        public const int c2 = c1 + 5;

        public SampleClass(int p1, int p2)
        {
            x = p1;
            y = p2;
        }
    }

}