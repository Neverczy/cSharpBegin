namespace switchcase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 绩效工资
            //Console.Write("输入课程评级:");
            //string rate = Console.ReadLine();
            //int money = 4000;
            //switch (rate)
            //{
            //    case "很兴奋":
            //        Console.WriteLine("评价A级,绩效工资加500");
            //        money += 500;
            //        break;
            //    case "很充实":
            //        Console.WriteLine("评级B级,无绩效工资");
            //        break;
            //    case "还好吧":
            //        Console.WriteLine("评级C级,绩效工资扣300");
            //        money -= 300;
            //        break;
            //    case "难理解":
            //        Console.WriteLine("评级D级,绩效工资扣500");
            //        money -= 500;
            //        break;
            //    case "枯燥乏味":
            //        Console.WriteLine("评级E级,绩效工资扣800");
            //        money -= 800;
            //        break;
            //    default:
            //        Console.WriteLine("输入有误!");
            //        break;
            //}
            //Console.WriteLine($"工资为 : {money}");
            #endregion
            #region 买星巴克
            //Console.WriteLine("购买星巴克咖啡");
            //Console.WriteLine("1.中杯 $5");
            //Console.WriteLine("2.大杯 $7");
            //Console.WriteLine("3.超大杯 $11");
            //Console.Write("请输入购买大小:");
            //string tp = Console.ReadLine();
            //int money = 10;
            //switch (tp)
            //{
            //    case "1":
            //        if (money >= 5)
            //        {
            //            Console.WriteLine("购买中杯成功,花费5元!");
            //            money -= 5;
            //        }
            //        else
            //        {
            //            Console.WriteLine("钱不够,请购买其他大小");
            //        }
            //            break;
            //    case "2":
            //        if (money >= 7)
            //        {
            //            Console.WriteLine("购买大杯成功,花费7元!");
            //            money -= 7;
            //        }
            //        else
            //        {
            //            Console.WriteLine("钱不够,请购买其他大小");
            //        }
            //        break;
            //    case "3":
            //        if (money >= 11)
            //        {
            //            Console.WriteLine("购买超大杯成功,花费11元!");
            //            money -= 11;
            //        }
            //        else
            //        {
            //            Console.WriteLine("钱不够,请购买其他大小");
            //        }
            //        break;
            //    default:
            //        Console.WriteLine("没有此大小,请重新输入!");
            //        break;
            //}
            //Console.WriteLine($"剩余金钱 : {money}");
            #endregion
            #region 成绩
            Console.Write("请输入成绩(0-100) : ");
            try
            {
                int score = int.Parse(Console.ReadLine());
                score /= 10;
                switch (score)
                {
                    case 10:
                    case 9:
                        Console.WriteLine("评级为A");
                        break;
                    case 8:
                        Console.WriteLine("评级为B");
                        break;
                    case 7:
                        Console.WriteLine("评级为C");
                        break;
                    case 6:
                        Console.WriteLine("评级为D");
                        break;
                    default:
                        Console.WriteLine("评级为E");
                        break;
                }
            }
            catch
            {
                Console.WriteLine("请输入数字!!");
            }
            #endregion
        }
    }
}
