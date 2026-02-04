using System.Diagnostics;
using System.Runtime.InteropServices;
namespace whileCricle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //while (true)
            //{
            //    //unsafe
            //    //{
            //    //    byte* buff;
            //    //    buff = (byte*)Marshal.AllocHGlobal(1000);
            //    //}
            //}
            #region 1.控制台输出1-100
            //int i1 = 1;
            //while (i1 <= 100)
            //{
            //    Console.WriteLine(i1);
            //    i1++;
            //}
            #endregion

            #region 2.控制台输出1-100总和
            //int i2 = 1;
            //int sum = 0;
            //while (i2 <= 100)
            //{
            //    sum += i2;
            //    i2++;
            //}
            //Console.WriteLine("总和为{0}",sum);
            #endregion

            #region 3.计算1-100除了能被7整除之外所有的和
            //int i3 = 0;
            //int sum = 0;
            //while (i3 < 100)
            //{
            //    i3++;
            //    if (i3 % 7 == 0)
            //    {
            //        continue;
            //    }
            //    sum += i3;
            //}
            //Console.WriteLine("拆除7整除后总和为 : {0}", sum);
            //4315
            #endregion

            #region 4.找素数
            Console.Write("带你找素数,请输入一个数 : ");
            try
            {
                int num4 = int.Parse(Console.ReadLine());
                int i4 = 2;
                while (i4 < num4)
                {                 
                    if (num4 % i4 == 0 )
                    {
                        break;
                    }
                    i4++;
                }
                if (i4 == num4)
                {
                    Console.WriteLine($"{num4}是素数");
                }
                else
                {
                    Console.WriteLine($"{num4}不是素数");
                }
            }
            catch
            {
                Console.WriteLine("输入错误,请输入一个数字!");
            }
            #endregion

            #region 输入账号密码admin/8888
            //while (true)
            //{
            //    Console.Write("请输入账号 : ");
            //    string acc = Console.ReadLine();
            //    Console.Write("请输入密码 : ");
            //    string pwd = Console.ReadLine();
            //    if(acc =="admin" && pwd == "8888")
            //    {
            //        Console.WriteLine("登录成功!");
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("用户名或密码错误,请重新登录!");
            //    }
            //}
            #endregion
        }
    }
}
