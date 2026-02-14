using System.Reflection;
using System.Runtime;

namespace hSavePGane
{
    struct Boss
    {
        public string name;
        public int positionX;
        public int positionY;
        public int maxHp;
        public int curHp;
        public string icon;
        public int maxAtk;
        public int minAtk;
        public int dodge;
    }
    internal class Program
    {
        static int windowWidth = 50;
        static int windowHeight = 30;
        static int gameScene = 0;
        static ConsoleColor myRed = ConsoleColor.Red;
        static ConsoleColor myWhite = ConsoleColor.White;
        static ConsoleColor myGreen = ConsoleColor.Green;
        static ConsoleColor myYellow = ConsoleColor.Yellow;
        static void Main(string[] args)
        {
            GameInit();
            GameUpdate();
        }
        static void GameInit()
        {
            Console.CursorVisible = false;
            Console.SetWindowSize(windowWidth, windowHeight);
            Console.SetBufferSize(windowWidth, windowHeight);
        }
        static void GameUpdate()
        {
            while (true) 
            {
                Console.Clear();
                switch (gameScene)
                {
                    case 0:
                        GameStart();
                        break;
                    case 1:
                        GamePlay();
                        break;
                    case 2:
                        GameEnd();
                        break;
                    default:
                        Console.WriteLine("wrong scene");
                        break;
                }
            }
        }
        static void GameStart()
        {
            int opt = 0;           
            Console.SetCursorPosition( windowWidth / 2 - 7 , 5 );
            Console.Write("人质救援大行动");
            while (true)
            {
                Console.SetCursorPosition(windowWidth / 2 - 4, 8);
                Console.ForegroundColor = opt == 0 ? myRed : myWhite;
                Console.Write("开始游戏");
                Console.ForegroundColor = opt == 1 ? myRed : myWhite;
                Console.SetCursorPosition(windowWidth / 2 - 4, 10);
                Console.Write("退出游戏");
                Console.ForegroundColor = myWhite;
                Console.SetCursorPosition(windowWidth - 42, windowHeight - 1);
                Console.Write("W : 上一选项 , S : 下一选项 , F : 确认");
                char ipt = Console.ReadKey(true).KeyChar;
                switch (ipt)
                {
                    case 'W':
                    case 'w':
                        opt -= 1;
                        opt = opt < 0 ? 0 : opt;
                        break;
                    case 'S':
                    case 's':
                        opt += 1;
                        opt = opt > 1 ? 1 : opt;
                        break;
                    case 'F':
                    case 'f':
                        if(opt == 0)
                        {
                            gameScene = 1;
                            return;
                        }else if(opt == 1)
                        {
                            Environment.Exit(0);
                        }
                            break;
                    default:
                        break;
                }         
            }
        }
        static void GamePlay()
        {
            Console.ForegroundColor = myRed;
            for (int i = 2; i < windowWidth; i += 2) 
            {
                Console.SetCursorPosition(i, 0);
                Console.Write("■");
                Console.SetCursorPosition(i, windowHeight - 1);
                Console.Write("■");
                Console.SetCursorPosition(i, windowHeight - 6);
                Console.Write("■");
            }
            for (int i = 0; i < windowHeight; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write("■");
                Console.SetCursorPosition(windowWidth - 2, i);
                Console.Write("■");
            }
            #region initBossStat
            Random r = new Random();
            Boss atanth;
            atanth.name = "阿坦斯";
            
            atanth.maxHp = 1000;
            atanth.curHp = 1000;
            atanth.positionX = r.Next(4 / 2, (windowWidth - 2 - 4) / 2 + 1) * 2;
            atanth.positionY = r.Next(2, windowHeight - 7);
            atanth.icon = "■";
            atanth.maxAtk = r.Next(15, 26);
            atanth.minAtk = r.Next(5, 11);
            atanth.dodge = r.Next(10, 36);
            #endregion
            #region initPlayerStat
            int pPX = 2;
            int pPy = 1;
            //----
            Console.ForegroundColor = myYellow;
            Console.SetCursorPosition(pPX, pPy);
            Console.Write("■");
            Console.ForegroundColor = myWhite;
            #endregion
            while (true) 
            {
                if (atanth.curHp > 0)
                {
                    Console.ForegroundColor = myGreen;                    
                    Console.SetCursorPosition(atanth.positionX, atanth.positionY);
                    Console.Write(atanth.icon);
                    Console.ForegroundColor = myWhite;
                }
                char ipt = Console.ReadKey(true).KeyChar;
                Console.SetCursorPosition(pPX, pPy);
                Console.Write("  ");
                switch (ipt)
                {
                    case 'W':
                    case 'w':
                        pPy -= 1;
                        if (pPy < 1)
                        {
                            pPy = 1;
                        }
                        else if(pPy == atanth.positionY && pPX == atanth.positionX && atanth.curHp > 0)
                        {
                            pPy += 1;
                        }
                        break;
                    case 'S':
                    case 's':
                        pPy += 1;
                        if(pPy > windowHeight - 7)
                        {
                            pPy = windowHeight - 7;
                        }
                        else if (pPy == atanth.positionY && pPX == atanth.positionX && atanth.curHp > 0)
                        {
                            pPy -= 1;
                        }
                        break;
                    case 'A':
                    case 'a':
                        pPX -= 2;
                        if (pPX < 2)
                        {
                            pPX = 2; 
                        }
                        else if(pPX == atanth.positionX && pPy == atanth.positionY && atanth.curHp > 0)
                        {
                            pPX += 2;
                        }
                        break;
                    case 'D':
                    case 'd':
                        pPX += 2;
                        if (pPX > windowWidth - 2 - 2)
                        {
                            pPX = windowWidth - 2 - 2;
                        }
                        else if(pPX == atanth.positionX && pPy == atanth.positionY && atanth.curHp > 0)
                        {
                            pPX -= 2;
                        }
                            break;
                    default:
                        break;
                }
                Console.ForegroundColor = myYellow;
                Console.SetCursorPosition(pPX, pPy);
                Console.Write("■");
                Console.ForegroundColor = myWhite;
            }
            ;
        }
        static void GameEnd()
        {
            Console.WriteLine("this is game end scene");
        }
    }
}
