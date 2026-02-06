namespace consoleFunc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //true 参数 使控制台不显示输入的字符
            char ipt = Console.ReadKey(true).KeyChar;
            Console.WriteLine("1111111");
            //清空控制台
            Console.Clear();
            //改变控制台窗口大小
            Console.SetWindowSize(150, 50);
            //改变控制台缓冲区大小
            Console.SetBufferSize(200, 100);
            //设置光标位置
            Console.SetCursorPosition(10, 5);
            Console.WriteLine("666");

            //ziji
            ConsoleColor fc = Console.ForegroundColor;
            ConsoleColor bc = Console.BackgroundColor;

            //设置文字颜色
            Console.ForegroundColor = ConsoleColor.Black;
            //设置背景颜色
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("this is test");
            Console.ForegroundColor = fc;
            Console.BackgroundColor = bc;

            //光标可见度
            Console.CursorVisible = false;

            //关闭控制台
            Environment.Exit(0);
        }
    }
}
