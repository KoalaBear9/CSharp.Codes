
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
    internal class Chapter_02_DataTypes
    {
        /// <summary>
        /// 程序的主入口点
        /// </summary>
        /// <param name="args">命令行参数</param>
        // public static void Main(string[] args)
        // {
        //     Console.WriteLine("int型数据大小为：{0}", sizeof(int));

        //     // 值类型转换为对象类型，装箱
        //     object objValue = 100;

        //     // 对象类型转换为值类型，拆箱
        //     int objToInt = (int)objValue;
        //     Console.WriteLine("objInt的值为：{0}", objToInt);

        //     string path = @"C:\Users\Administrator\Desktop\test.txt";
        //     Console.WriteLine("路径：{0}", path);

        //     int number =9;
        //     object intToObj;
        //     intToObj = number;
        //     intToObj=10;
        //     Console.WriteLine("2 number的值为：{0}", number);
        //     Console.WriteLine("1 intToObj的值为：{0}", intToObj);

        //     // 值类型存储在栈,开辟空间存放值
        //     int number1 = 5;
        //     int number2=number1;
        //     Console.WriteLine("number1的值为：{0},number2的值为：{1}", number1,number2);
        //     number2=7;
        //     Console.WriteLine("number1的值为：{0},number2的值为：{1}", number1,number2);

        //     // 引用类型在堆中开辟空间，保存值,在栈中存放地址。开辟空间存放值
        //     string[] strArr1 = new string[]{ "a" , "b" , "c" };
        //     string[] strArr2 = strArr1;
        //     for(int i = 0; i < strArr2.Length; i++)
        //     {
        //         Console.Write(strArr2[i] + " ");    //a b c
        //     }
        //     strArr1[2] = "d";
        //     Console.WriteLine();            //换行
        //     for(int i = 0; i < strArr2.Length; i++)
        //     {
        //         Console.Write(strArr2[i] + " ");    //a b d
        //     }
        //     Console.WriteLine(); 
        //     Console.ReadLine();
        // }
    }
}