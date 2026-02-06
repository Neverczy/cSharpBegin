namespace consoleTest
{
    internal class Program
    {
        static int width = 200;
        static int height = 60;
        static int cpx = 0;
        static int cpy = 0;
        static void Main(string[] args)
        {
            init();
            //Console.WriteLine(Console.BufferWidth);
            //Console.WriteLine(Console.BufferHeight);

            playplay();
        }

        static void init()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetWindowSize(width, height);
            Console.SetBufferSize(width, height);
            Console.CursorVisible = false;
            Console.Clear();
            Console.Write("口");
        }
        static void playplay()
        {
            while (true) 
            {
                char ipt = Console.ReadKey(true).KeyChar;
                Console.SetCursorPosition(cpx, cpy);
                Console.Write(" ");
                switch (ipt)
                {
                    case 'W':
                    case 'w':
                        if(cpy - 1 < 0)
                        {
                            cpy = 0;
                        }
                        else
                        {
                            cpy -= 1;
                        }
                            break;
                    case 'A':
                    case 'a':
                        if (cpx - 2 < 0)
                        {
                            cpx = 0;
                        }
                        else
                        {
                            cpx -= 2;
                        }                          
                        break;
                    case 'S':
                    case 's':
                        if (cpy + 1 > height-1)
                        {
                            cpy = height - 1;
                        }
                        else
                        {
                            cpy += 1;
                        }
                        break;
                    case 'D':
                    case 'd':
                        if (cpx + 2 > width-2 )
                        {
                            cpx = width - 2;
                        }
                        else
                        {
                            cpx += 2;
                        }
                        break;
                    default:
                        break;
                }
                //Console.Clear();
                Console.SetCursorPosition(cpx, cpy);
                Console.Write("口");
            }
        }
    }
}
