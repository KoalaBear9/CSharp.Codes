
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
    internal class Chapter_01_BasicSyntax_1
    {
        /// <summary>
        /// 程序的主入口点
        /// </summary>
        /// <param name="args">命令行参数</param>
        // public static void Main(string[] args)
        // {
        //     // 创建一个矩形对象
        //     Rectangle rectangle = new Rectangle();
        //     // 调用矩形的Display方法显示其属性
        //     rectangle.Length = 10;
        //     rectangle.Display();
        //     // 等待用户输入，以便用户能看到控制台输出
        //     Console.ReadLine();
        // }
    }

    /// <summary>
    /// Rectangle 类表示一个矩形，并能计算其面积
    /// </summary>
    internal class Rectangle
    {
        // 定义长度和宽度的实例变量
        private double length;
        private double width;

        /// <summary>
        /// 设置默认的长度和宽度值
        /// </summary>
        public void Acceptdetails()
        {
            length = 5.5;    
            width = 4.5;
        }

        /// <summary>
        /// Length 属性，获取或设置矩形的长度
        /// </summary>
        public double Length
        {
            get { return length; }
            set { length = value; }
        }

        /// <summary>
        /// Width 属性，获取或设置矩形的宽度
        /// </summary>
        public double Width
        {
            get { return width; }
            set { width = value; }
        }

        /// <summary>
        /// Rectangle 构造函数，初始化矩形的长度和宽度
        /// </summary>
        public Rectangle()
        {
            length = 4.5;
            width = 3.5;
        }

        /// <summary>
        /// 获取矩形的面积
        /// </summary>
        /// <returns>矩形的面积</returns>
        public double GetArea()
        {
            return length * width;
        }

        /// <summary>
        /// Display 方法，打印矩形的长度、宽度和面积
        /// </summary>
        public void Display()
        {
            Console.WriteLine("Length: {0}", length);
            Console.WriteLine("Width: {0}", width);
            Console.WriteLine("Area: {0}", GetArea());
        }
    }
}