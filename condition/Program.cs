namespace condition;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        System.Console.WriteLine("test01 ----------");
        try
        {
            System.Console.Write("please input a number of min : ");
            int mins = int.Parse(Console.ReadLine());
            if (mins > 60) { System.Console.WriteLine("you study more 60 mins,you will success!"); }
        }
        catch { System.Console.WriteLine("please input number!"); }

        System.Console.WriteLine("test02 ----------");
        try
        {
            Console.Write("please input chinese score : ");
            int cs = int.Parse(Console.ReadLine());
            Console.Write("please input math score : ");
            int ms = int.Parse(Console.ReadLine());
            Console.Write("please input english score : ");
            int es = int.Parse(Console.ReadLine());
            if (cs > 70 && ms > 80 && es > 90)
            {
                Console.WriteLine("you good!,go up!");
            }
            else if (cs == 100 || ms == 100 || es == 100)
            {
                Console.WriteLine("you good!,go up!");
            }
            else if (cs > 90 && (ms > 70 || es > 70))
            {
                Console.WriteLine("you good!,go up!");
            }
        }
        catch { System.Console.WriteLine("please input number"); }

        System.Console.WriteLine("test03 ----------");
        int examS = 90;
        if (examS >= 90)
        {
            System.Console.WriteLine("奖励100元");
        }
        else
        {
            System.Console.WriteLine("一个月不玩游戏");
        }

        System.Console.WriteLine("test04 three int find max ----------");
        int i1 = 10;
        int i2 = 20;
        int i3 = 15;
        if (i1 > i2 && i1 > i3)
        {
            System.Console.WriteLine($"max number is {i1}");
        }
        else if (i2 > i1 && i2 > i3)
        {
            System.Console.WriteLine($"max number is {i2}");
        }
        else
        {
            System.Console.WriteLine($"max number is {i3}");
        }

        System.Console.WriteLine("test05 mind number----------");
        Console.Write("input a char : ");
        int ic = Console.ReadKey().KeyChar;
        int zc = '0';
        int nc = '9'; ;
        if (ic >= zc && ic <= nc)
        {
            System.Console.WriteLine("your inputed a number");
        }
        else
        {
            System.Console.WriteLine("your inputed not a number");
        }

        System.Console.WriteLine("test06 name and pwd mind----------");
        System.Console.Write("input username : ");
        string usrname = Console.ReadLine();
        System.Console.Write("input password : ");
        string pwd = Console.ReadLine();
        if (usrname == "admin" && pwd == "8888")
        {
            System.Console.WriteLine("login success");
        }
        else if (usrname != "admin")
        {
            System.Console.WriteLine("username not include!");
        }
        else
        {
            System.Console.WriteLine("password wrong!");
        }

        System.Console.WriteLine("test07 age mind----------");
        System.Console.Write("input an age : ");
        try
        {
            int age = int.Parse(Console.ReadLine());
            if (age >= 18)
            {
                System.Console.WriteLine("access pass");
            }
            else if (age < 13)
            {
                System.Console.WriteLine("access denied");
            }
            else
            {
                System.Console.WriteLine("continue to access? (yes/no) ");
                string cta = Console.ReadLine();
                if (cta == "yes")
                {
                    System.Console.WriteLine("access pass");
                }
                else
                {
                    System.Console.WriteLine("exit");
                }
            }
        }
        catch { System.Console.WriteLine("input a number"); }

        System.Console.WriteLine("test08 write result----------");
        //  6

    }
}
