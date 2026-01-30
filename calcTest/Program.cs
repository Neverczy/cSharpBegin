namespace calcTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----- test 01 input age and add ten -----");
            try
            {
                Console.Write("please input a age : ");
                int age = int.Parse(Console.ReadLine());
                Console.WriteLine($"after ten years ago your age is {(age+10).ToString()}");
            }
            catch
            {
                Console.WriteLine("age must be a number !!");
            }

            Console.WriteLine("\n\n----- test 02 calc circal area and length -----");
            Console.WriteLine($"half 5 circal ares is {Math.PI*5*5}");
            Console.WriteLine($"half 5 circal length is {2*Math.PI*5}");

            Console.WriteLine("\n\n----- test 03 calc three subject score avg and  sub -----");
            int cScore = 80;
            int mScore = 70;
            int eScore = 90;
            Console.WriteLine($"chinese subject score is {cScore}");
            Console.WriteLine($"math subject score is {mScore}");
            Console.WriteLine($"english subject score is {eScore}");
            Console.WriteLine($"sub three socre is {cScore+mScore+eScore}");
            Console.WriteLine($"avg three socre is {(cScore + mScore + eScore)/3}");

            Console.WriteLine("\n\n----- test 04 calc goods price -----");
            Console.WriteLine("shopping  the t-shirt price is 285,pant price is 720,tim bought 2 t-shirts and 3 pants,calc how much must pay and make 3.8 discount");
            Console.WriteLine($"2 ts and 3 pant total price is {285*2+720*3}");
            Console.WriteLine($"make 3.8 discount total price is {(285*2+720*3)*0.38}");

            Console.WriteLine("\n\n----- test 05 make some calc -----");
            Console.WriteLine("int a = 10;\tint b = 20;");
            Console.WriteLine($"\t\tint number1 = ++a+b is {31}");
            Console.WriteLine("int a = 10;\tint b = 20;");
            Console.WriteLine($"\t\tint number2 = a+b++ is {30}");
            Console.WriteLine("int a = 10;\tint b = 20;");
            Console.WriteLine($"\t\tint number3 = a++ + ++b + a++ is {42}");

            Console.WriteLine("\n\n----- test 06 switch two val value -----");
            int a = 0;
            int b = 0;
            Console.WriteLine("two numbers a = 99\tb=87 make two ways switch their value");
            Console.WriteLine("way 01");
            a = 99;
            b = 87;
            int c = 0;
            c = a;
            a = b;
            b = c;
            Console.WriteLine($"a = {a}\tb = {b}");
            Console.WriteLine("way 02");
            a = 99;
            b = 87;
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine($"a = {a}\tb = {b}");

            Console.WriteLine("\n\n----- test 07 switch 987652 seconds  to x days n hours n mins n second -----");
            int second = 987652;
            int dd = second / 86400/*(60 * 60 * 24)*/;
            int hh = second % 86400 /60/60;
            int mm = second % 3600 / 60;
            int ss = second % 60;
            Console.WriteLine($"987652 seconds is \n{dd} days\n{hh} hours\n{mm} mins\n{ss} seconds");
            //1000110000 1025+32+16 1057+16 1073 wrong
            //1000010 1+32 33

            //99^33 
            //1100011
            //0100001
            //1000010 =66

            //76 | 85
            //1001100
            //1010101
            //1011101 64+16+8+4+1 93

            int ii = 0;
            if (false)
            {
                ii = 20;
            }
            else
            {
                ii = 100;
            }
            Console.WriteLine(ii);
        }
    }
}
