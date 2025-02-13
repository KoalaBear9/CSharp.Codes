
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
    internal class Chapter_06_Operators_3
    {
        /// 程序的主入口点
        /// </summary>
        /// <param name="args">命令行参数</param>
        public static void Main(string[] args)
        {
            {
                int a = 60;            /* 60 = 0011 1100 */
                int b = 13;            /* 13 = 0000 1101 */
                int c = 0;

                c = a & b;           /* 12 = 0000 1100 */
                Console.WriteLine("Line 1 - c 的值是 {0}", c);

                c = a | b;           /* 61 = 0011 1101 */
                Console.WriteLine("Line 2 - c 的值是 {0}", c);

                c = a ^ b;           /* 49 = 0011 0001 */
                Console.WriteLine("Line 3 - c 的值是 {0}", c);

                c = ~a;               /*-61 = 1100 0011 */
                Console.WriteLine("Line 4 - c 的值是 {0}", c);

                c = a << 2;     /* 240 = 1111 0000 */
                Console.WriteLine("Line 5 - c 的值是 {0}", c);

                c = a >> 2;     /* 15 = 0000 1111 */
                Console.WriteLine("Line 6 - c 的值是 {0}", c);
            }

            {
                // 掩码操作（Bitmasking）
                // 场景：提取或设置数据的特定位，常见于硬件寄存器操作、协议解析、图像处理等。
                const byte FLAG_A = 1 << 0;   // 0000 0001
                const byte FLAG_B = 1 << 1;   // 0000 0010

                byte flags = 0b00000011;

                // 检查是否包含 FLAG_B
                if ((flags & FLAG_B) != 0)
                {  // 0b00000011 & 0b00000010 → 0b00000010 (非0)
                    Console.WriteLine("FLAG_B 已设置");
                }

                // 示例2：清除指定位（将第3位设为0）
                flags &= unchecked((byte)~(1 << 2));  // 清除第3位（从0计数）
                Console.WriteLine($"清除第3位后，flags 的值是 {Convert.ToString(flags, 2).PadLeft(8, '0')}"); // 清除第3位（从0计数）
                flags &= (byte)(~(1 << 2) & 0xFF); ;  // 清除第3位（从0计数）
                Console.WriteLine($"清除第3位后，flags 的值是 {Convert.ToString(flags, 2).PadLeft(8, '0')}"); // 清除第3位（从0计数）
            }


            {
                // 掩码操作（Bitmasking）
                // 场景：提取或设置数据的特定位，常见于硬件寄存器操作、协议解析、图像处理等。
                const byte FLAG_A = 1 << 0;   // 0000 0001
                const byte FLAG_B = 1 << 1;   // 0000 0010

                byte flags = 0b00000011;

                // 检查是否包含 FLAG_B
                if ((flags & FLAG_B) != 0)
                {  // 0b00000011 & 0b00000010 → 0b00000010 (非0)
                    Console.WriteLine("FLAG_B 已设置");
                }

                // 示例2：清除指定位（将第3位设为0）
                flags &= unchecked((byte)~(1 << 2));  // 清除第3位（从0计数）
                Console.WriteLine($"清除第3位后，flags 的值是 {Convert.ToString(flags, 2).PadLeft(8, '0')}"); // 清除第3位（从0计数）
                flags &= (byte)(~(1 << 2) & 0xFF); ;  // 清除第3位（从0计数）
                Console.WriteLine($"清除第3位后，flags 的值是 {Convert.ToString(flags, 2).PadLeft(8, '0')}"); // 清除第3位（从0计数）
            }

            {
                // 紧凑存储多个布尔值
                // 场景：用单个整型变量存储多个开关状态，节省内存。
                // 设置用户的读写权限
                uint user_permissions = (uint)(Permissions.READ | Permissions.WRITE);  // 0011

                // 检查是否有执行权限
                if ((user_permissions & (uint)Permissions.EXECUTE) == 0)
                {
                    Console.WriteLine("无执行权限");
                }
            }

            {
                // 快速乘除运算
                // 场景：用位移代替乘除2的幂次方，提升性能（编译器通常自动优化，但显式使用可增强代码意图）。
                int a = 8;
                int b = a << 3;  // 8 * 2^3 = 64
                int c = a >> 1;  // 8 / 2^1 = 4
                Console.WriteLine($"{a} << 3");
                Console.WriteLine($"{a} * 2^3 = {b}");
                Console.WriteLine($"{a} >> 1");
                Console.WriteLine($"{a} / 2^1 = {c}");
            }

            {
                // 交换变量值（不使用临时变量）
                // 场景：异或运算实现原地交换，减少内存使用（适用于嵌入式等资源受限环境）。
                int x = 5, y = 3;
                Console.WriteLine($"交换前：x = {x}, y = {y}");
                x ^= y;  // x = 5 ^ 3 (0110)
                y ^= x;  // y = 3 ^ 6 (0101 → 5)
                x ^= y;  // x = 6 ^ 5 (0011 → 3)
                Console.WriteLine($"交换后：x = {x}, y = {y}"); // 结果：x=3, y=5
            }

            {
                // 颜色值处理（ARGB/RGBA格式）
                // 场景：图像处理中分解或合成颜色通道。
                // 将32位ARGB颜色分解为各通道
                UInt32 color = 0xFF336699;
                byte alpha = (byte)((color >> 24) & 0xFF);  // 0xFF
                byte red = (byte)((color >> 16) & 0xFF);    // 0x33
                byte green = (byte)((color >> 8) & 0xFF);   // 0x66
                byte blue = (byte)(color & 0xFF);           // 0x99

                // 重新合成颜色
                UInt32 new_color = (UInt32)((alpha << 24) | (red << 16) | (green << 8) | blue);

                Console.WriteLine($"Original Color: {color:X8}");
                Console.WriteLine($"New Color: {new_color:X8}");
            }


            {
                // 加密与校验算法
                // 场景：异或用于简单加密，CRC校验中使用位运算。
                // 示例：异或加密
                string data = "Hello";
                byte key = 0x55;

                // 将字符串转换为字节数组
                byte[] dataArray = System.Text.Encoding.UTF8.GetBytes(data);

                // 加密
                for (int i = 0; i < dataArray.Length; i++)
                {
                    dataArray[i] ^= key;  // 加密
                }

                // 解密（再次异或恢复原数据）
                for (int i = 0; i < dataArray.Length; i++)
                {
                    dataArray[i] ^= key;
                }

                // 将字节数组转换回字符串并输出
                string decryptedData = System.Text.Encoding.UTF8.GetString(dataArray);
                Console.WriteLine("解密后的字符串: " + decryptedData);

            }
            Console.ReadLine();
        }

        // 定义权限标志位
        enum Permissions
        {
            READ = 1 << 0,    // 0001
            WRITE = 1 << 1,   // 0010
            EXECUTE = 1 << 2  // 0100
        }
    }
}