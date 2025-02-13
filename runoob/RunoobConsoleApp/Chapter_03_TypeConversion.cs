
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
    internal class Chapter_03_TypeConversion
    {
        /// <summary>
        /// 程序的主入口点
        /// </summary>
        /// <param name="args">命令行参数</param>
        /* 
        public static void Main(string[] args)
        {
            // 隐式转换
            byte byte1 = 10;
            int int1 = byte1;
            Console.WriteLine("int1的值为：{0}", int1);

            // 显示转换
            double double1 = 1.34;
            int int2 = (int)double1;
            Console.WriteLine("int2的值为：{0}", int2);
            Console.WriteLine("Hello World!");

            // 定义一个整型变量
            int intNumber = 75;

            // 定义一个双精度浮点型变量
            float floatNumber = 53.005f;

            // 定义一个双精度浮点型变量
            double doubleNumber = 2345.7652;

            // 定义一个布尔型变量
            bool boolNumber = true;

            // 将整型变量转换为字符串并输出
            Console.WriteLine("整型变量转换为字符串并输出：{0}", intNumber.ToString());

            // 将浮点型变量转换为字符串并输出
            Console.WriteLine("浮点型变量转换为字符串并输出：{0}", floatNumber.ToString());

            // 将双精度浮点型变量转换为字符串并输出
            Console.WriteLine("双精度浮点型变量转换为字符串并输出：{0}", doubleNumber.ToString());

            // 将布尔型变量转换为字符串并输出
            Console.WriteLine("布尔型变量转换为字符串并输出：{0}", boolNumber.ToString());

            // Convert 类提供了一组静态方法，可以在各种基本数据类型之间进行转换。
            string str1 = "123";
            int num1 = Convert.ToInt32(str1);
            Console.WriteLine("字符串转换为整型变量并输出：{0}", num1);

            // Parse 方法用于将字符串转换为对应的数值类型，如果转换失败会抛出异常。
            string str2 = "123.450";
            double num2 = double.Parse(str2);
            Console.WriteLine("字符串转换为双精度浮点型变量并输出：{0}", num2);

            // TryParse 方法类似于 Parse，但它不会抛出异常，而是返回一个布尔值指示转换是否成功。
            string str3 = "123.450";
            double num3;
            bool success = double.TryParse(str3, out num3);

            if (success)
            {
                Console.WriteLine("转换成功: " + num3);
            }
            else
            {
                Console.WriteLine("转换失败:" + num3);
            }

            //调用自定义类型转换方法
            Fahrenheit fahrenheit = new Fahrenheit(98.6);
            Console.WriteLine("Fahrenheit object: " + fahrenheit.Degrees + " degrees");

            double temp = fahrenheit; // 隐式转换
            Console.WriteLine("After implicit conversion to double: " + temp + " degrees");

            Fahrenheit newFahrenheit = (Fahrenheit)temp; // 显式转换
            Console.WriteLine("After explicit conversion back to Fahrenheit: " + newFahrenheit.Degrees + " degrees");

            int num4 = 100;
            long lnum4 = num4; // 进行了隐式转换，将 int 型（数据范围小）数据转换为了 long 型（数据范围大）的数据
            ClassA classA = new ClassB(); // 这里也是隐式转换，将一个新建的 Class2 实例转换为了其基类 Class1 类型的实例 C1

            Console.WriteLine("输入数字，将计算出它加一的答案");
            if (int.TryParse(Console.ReadLine(), out int input))
            {
                Console.WriteLine("答案是{0}", ++input); // ++a 即 a+1 后的那个数，将它输出出来
            }
            else
            {
                Console.WriteLine("输入无效，请输入一个有效的整数。");
            }

            Console.ReadLine();
        }
        */
    }

    internal class Fahrenheit
    {
        public double Degrees { get; set; }
        public Fahrenheit(double degrees)
        {
            this.Degrees = degrees;
        }

        /// <summary>
        /// 隐式转换从Fahrenheit到double
        /// </summary>
        /// <param name="fahrenheit"></param>
        public static implicit operator double(Fahrenheit fahrenheit)
        {
            return fahrenheit.Degrees;
        }

        /// <summary>
        /// 显式转换从double到Fahrenheit
        /// </summary>
        /// <param name="degrees"></param>
        public static explicit operator Fahrenheit(double degrees)
        {
            return new Fahrenheit(degrees);
        }
    }

    internal class ClassA
    {

    }
    internal class ClassB : ClassA
    {

    }
}