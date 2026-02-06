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
            //Console.Write("带你找素数,请输入一个数 : ");
            //try
            //{
            //    int num4 = int.Parse(Console.ReadLine());
            //    int i4 = 2;
            //    while (i4 < num4)
            //    {                 
            //        if (num4 % i4 == 0 )
            //        {
            //            break;
            //        }
            //        i4++;
            //    }
            //    if (i4 == num4)
            //    {
            //        Console.WriteLine($"{num4}是素数");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{num4}不是素数");
            //    }
            //}
            //catch
            //{
            //    Console.WriteLine("输入错误,请输入一个数字!");
            //}
            #endregion

            #region 5.输入账号密码admin/8888
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

            #region 6.输入班级人数,依次输入成绩,提示当前第几个学员,计算平均成绩和总成绩. 
            //Console.Write("请输入班级人数 : ");
            //try
            //{
            //    int stuNum = int.Parse(Console.ReadLine());
            //    int counter = 1;
            //    int totalScore = 0;
            //    while (counter <= stuNum)
            //    {
            //        Console.Write($"请输入第{counter}个学员的成绩 : ");
            //        int score = int.Parse(Console.ReadLine());
            //        counter++;
            //        totalScore += score;
            //    }
            //    Console.Write($"总学员数:{stuNum}\t总成绩:{totalScore}\t平均成绩:{totalScore/stuNum}");
            //}
            //catch 
            //{
            //    Console.WriteLine("错误,请输入数字!");
            //}
            #endregion

            #region 7.定义变量sum,把1-100累加,当sum值大于500时,中断,控制台输出累加到第几个数字后可以是sum大于500
            //int counter = 1;
            //int i = 1;
            //int sum = 0;
            //while (i <= 100)
            //{   
            //    sum += i;
            //    if (sum > 500)
            //    {
            //        break;
            //    }
            //    i++;
            //    counter++;

            //}
            //Console.WriteLine($"累加到第 : {counter}次后,sum值大于500,值为 : {sum}");
            #endregion

            #region 8.总共100人,每月增长20人,多少个月能1000人
            //double init = 100;
            //int month = 0;
            //while (init <=1000)
            //{
            //    init *= 1.2;
            //    month++;
            //}
            //Console.WriteLine($"{month}个月后,人数超过1000");
            #endregion

            #region 9.数列1,1,2,3,5,8... 第20位是什么数字
            //int n1 = 1;
            //int n2 = 1;
            //int i = 1;
            //int cn = 0;
            //while (i<=18)
            //{
            //    cn = n1 + n2;
            //    n1 = n2;
            //    n2 = cn;
            //    i++;
            //}
            //Console.WriteLine($"第20位数字是 : {cn}");
            #endregion

            #region 10.找出100内所有素数打印
            //int i = 2;
            //while (i <= 100) {
            //    int j = 2;
            //    while (j < i)
            //    {  
            //        if (i%j==0)
            //        {
            //            break;
            //        }
            //        j++;
            //    }
            //    if (i == j)
            //    {
            //        Console.WriteLine($"{i}\t");
            //    }
            //    i++;
            //}
            #endregion

            #region 11. do...while() 不断提示输入姓名,直到输入q结束
            do
            {
                Console.Write("请输入姓名 : ");
                string name = Console.ReadLine();
                if(name == "q")
                {
                    break;
                }
            } while (true);
            #endregion
        }
    }
}
