namespace begin01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int i = 100;
            //short s = (short)i;
            //Console.WriteLine(s);
            //int i2 = Convert.ToInt32('B');
            //Console.WriteLine(i2);
            #region make 24069 convert to  char
            int i1 = 24069;
            char c1 = Convert.ToChar(i1);
            Console.WriteLine(c1);
            #endregion
            #region input name score and add socre
            Console.Write("please input your name : ");
            string name = Console.ReadLine();
            Console.Write("please input your chinese score : ");
            string cScore = Console.ReadLine();
            Console.Write("please input your math score : ");
            string mScore = Console.ReadLine();
            Console.Write("please input your english score : ");
            string eScore = Console.ReadLine();
            int subScore = Convert.ToInt32(cScore) + Convert.ToInt32(mScore) + Convert.ToInt32(eScore);
            Console.WriteLine("--------------------");
            Console.WriteLine($"your name : {name}");
            Console.WriteLine($"your chinese score : {cScore}");
            Console.WriteLine($"your math score : {mScore}");
            Console.WriteLine($"your english score : {eScore}");
            Console.WriteLine($"your total subject score : {subScore}");
            Console.WriteLine("--------------------");
            #endregion
        }
    }
}
