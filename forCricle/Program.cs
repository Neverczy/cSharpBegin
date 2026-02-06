namespace forCricle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1.输出1-100整数
            //for (int i = 1; i <= 100; i++)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion

            #region 2.输出1-100偶数和
            //int sum = 0;
            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i%2 == 0)
            //    {
            //        sum += i;
            //    }
            //}
            //Console.WriteLine($"1-100之间偶数和为 : {sum}");
            #endregion

            #region 3.输出100-999之间水仙花数
            //for (int i = 100; i <=999; i++)
            //{
            //    int h = i / 100;
            //    int t = i % 100 / 10;
            //    int g = i % 10;
            //    if (h * h * h + t * t * t + g * g * g == i)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            #endregion

            #region 4.输出99乘法表
            //for (int i = 1; i <= 9; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write($"{j} * {i} = {i*j}\t");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region 5.控制台输出10*10 空心方阵
            //for (int i = 0; i < 10; i++)
            //{
            //    for (int j = 0; j < 10; j++)
            //    {
            //        if (i == 0 || i == 9 || j == 0 || j == 9)
            //        {
            //            Console.Write("*");
            //        }
            //        else
            //        {
            //            Console.Write(" ");
            //        }
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region 6.输出10*10三角
            //for (int i = 0; i < 10; i++)
            //{
            //    for (int j = 0; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region 7.输出等腰三角形方针
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j <= 10-i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k <=i*2; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            #endregion
        }
    }
}
