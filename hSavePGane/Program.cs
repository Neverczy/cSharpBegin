
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
        public int def;
        public int dodge;
        public bool isFight;
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
        static ConsoleColor myBlue = ConsoleColor.Blue;
        static bool gameResult = false;
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
            
            atanth.maxHp = 888;
            atanth.curHp = 888;
            atanth.positionX = r.Next(4 / 2, (windowWidth - 2 - 4) / 2 + 1) * 2;
            atanth.positionY = r.Next(2, windowHeight - 7);
            atanth.icon = "■";
            atanth.maxAtk = r.Next(15, 26);
            atanth.minAtk = r.Next(5, 11);
            atanth.dodge = r.Next(12, 26);
            atanth.isFight = false;
            #endregion
            #region initPlayerStat
            Boss datith;
            datith.name = "达狄斯";
            datith.maxHp = 200;
            datith.curHp = 200;
            datith.positionX = 2;
            datith.positionY = 1;
            datith.icon = "●";
            datith.maxAtk = r.Next(30, 41);
            datith.minAtk = r.Next(16, 23);
            datith.def = r.Next(6, 13);
            datith.isFight = false;
            //----
            Console.ForegroundColor = myYellow;
            Console.SetCursorPosition(datith.positionX, datith.positionY);
            Console.Write(datith.icon);
            Console.ForegroundColor = myWhite;
            #endregion

            #region initPrincess
            Boss princess;
            princess.name = "普林塞斯";
            princess.positionX = 0;
            princess.positionY = 0;
            princess.icon = "●";
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
                else
                {
                    Console.ForegroundColor = myBlue;
                    Console.SetCursorPosition(princess.positionX, princess.positionY);
                    Console.Write(princess.icon);
                    Console.ForegroundColor = myBlue;
                }
                    char ipt = Console.ReadKey(true).KeyChar;
                if (datith.isFight && atanth.isFight)
                {
                    if (ipt == 'F' || ipt == 'f')
                    {
                        int datithDmg = r.Next(datith.minAtk, datith.maxAtk + 1);
                        int atanthDmg = r.Next(atanth.minAtk, atanth.maxAtk + 1);
                        int isDodged = r.Next(1, 101);
                        int datithRDmg = isDodged <= atanth.dodge ? 0 : datithDmg;
                        int atanthRDmg = atanthDmg - datith.def < 0 ? 0 : atanthDmg - datith.def;
                        atanth.curHp = atanth.curHp - datithRDmg < 0 ? 0 : atanth.curHp - datithRDmg;
                        datith.curHp = datith.curHp - atanthRDmg < 0 ? 0 : datith.curHp - atanthRDmg;                       
                        if (datith.curHp == 0)
                        {
                            Console.ForegroundColor = myRed;
                            Console.SetCursorPosition(2, windowHeight - 5);
                            Console.Write("                                              ");
                            Console.SetCursorPosition(2, windowHeight - 5);
                            Console.Write($"{datith.name}已死亡,游戏失败!!");
                            Console.ForegroundColor = myYellow;
                            Console.SetCursorPosition(2, windowHeight - 4);
                            Console.Write("                                              ");
                            Console.SetCursorPosition(2, windowHeight - 4);
                            Console.Write($"<{datith.name}> 生命值:{datith.curHp}/{datith.maxHp}");
                            Console.ForegroundColor = myGreen;
                            Console.SetCursorPosition(2, windowHeight - 3);
                            Console.Write("                                              ");
                            Console.SetCursorPosition(2, windowHeight - 3);
                            Console.Write($"<{atanth.name}> 生命值:{atanth.curHp}/{atanth.maxHp}");
                            Console.ForegroundColor = myRed;
                            Console.SetCursorPosition(2, windowHeight - 2);
                            Console.Write("                                              ");
                            Console.SetCursorPosition(2, windowHeight - 2);
                            Console.Write("按<任意键>结束");
                            gameResult = false;
                            Console.ForegroundColor = myWhite;
                            char iEt = Console.ReadKey(true).KeyChar;
                            gameScene = 2;
                            break;
                        }
                        else if(atanth.curHp == 0)
                        {
                            Console.ForegroundColor = myGreen;
                            Console.SetCursorPosition(2, windowHeight - 5);
                            Console.Write("                                              ");
                            Console.SetCursorPosition(2, windowHeight - 5);
                            Console.Write($"{atanth.name}已死亡,恭喜你击败了{atanth.name}!!");
                            Console.ForegroundColor = myYellow;
                            Console.SetCursorPosition(2, windowHeight - 4);
                            Console.Write("                                              ");
                            Console.SetCursorPosition(2, windowHeight - 4);
                            Console.Write($"<{datith.name}> 生命值:{datith.curHp}/{datith.maxHp}");
                            Console.ForegroundColor = myGreen;
                            Console.SetCursorPosition(2, windowHeight - 3);
                            Console.Write("                                              ");
                            Console.SetCursorPosition(2, windowHeight - 3);
                            Console.Write($"<{atanth.name}> 生命值:{atanth.curHp}/{atanth.maxHp}");
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.SetCursorPosition(2, windowHeight - 2);
                            Console.Write("                                              ");
                            Console.SetCursorPosition(2, windowHeight - 2);
                            Console.Write("请前往营救公主!!");
                            Console.ForegroundColor = myWhite;
                            Console.SetCursorPosition(atanth.positionX, atanth.positionY);
                            Console.Write("  ");
                            datith.isFight = false;
                            atanth.isFight = false;
                            princess.positionX = r.Next(4 / 2, (windowWidth - 2 - 4) / 2 + 1) * 2;
                            princess.positionY = r.Next(2, windowHeight - 7);
                        }
                        else
                        {
                            Console.ForegroundColor = myYellow;
                            Console.SetCursorPosition(2, windowHeight - 4);
                            Console.Write("                                              ");
                            Console.SetCursorPosition(2, windowHeight - 4);
                            Console.Write($"<{datith.name}> 生命值:{datith.curHp}/{datith.maxHp} 攻击力:{datith.minAtk}-{datith.maxAtk} 防御力:{datith.def}");
                            Console.ForegroundColor = myGreen;
                            Console.SetCursorPosition(2, windowHeight - 3);
                            Console.Write("                                              ");
                            Console.SetCursorPosition(2, windowHeight - 3);
                            Console.Write($"<{atanth.name}> 生命值:{atanth.curHp}/{atanth.maxHp} 攻击力:{atanth.minAtk}-{atanth.maxAtk} 闪避:{atanth.dodge}%");
                            Console.ForegroundColor = myWhite;
                            Console.SetCursorPosition(2, windowHeight - 2);
                            Console.Write("                                              ");
                            Console.SetCursorPosition(2, windowHeight - 2);
                            Console.Write($"{datith.name}->{atanth.name}:{(datithRDmg == 0 ? "闪避" : datithRDmg)}\t{atanth.name}->{datith.name}:{atanthRDmg}");
                        }
                    }
                }
                else
                {
                    Console.SetCursorPosition(datith.positionX, datith.positionY);
                    Console.Write("  ");
                    switch (ipt)
                    {
                        case 'W':
                        case 'w':
                            datith.positionY -= 1;
                            if (datith.positionY < 1)
                            {
                                datith.positionY = 1;
                            }
                            else if ((datith.positionY == atanth.positionY && datith.positionX == atanth.positionX && atanth.curHp > 0 )
                                ||(datith.positionY == princess.positionY && datith.positionX == princess.positionX) )
                            {
                                datith.positionY += 1;
                            }
                            break;
                        case 'S':
                        case 's':
                            datith.positionY += 1;
                            if (datith.positionY > windowHeight - 7)
                            {
                                datith.positionY = windowHeight - 7;
                            }
                            else if ((datith.positionY == atanth.positionY && datith.positionX == atanth.positionX && atanth.curHp > 0)
                                || (datith.positionY == princess.positionY && datith.positionX == princess.positionX))
                            {
                                datith.positionY -= 1;
                            }
                            break;
                        case 'A':
                        case 'a':
                            datith.positionX -= 2;
                            if (datith.positionX < 2)
                            {
                                datith.positionX = 2;
                            }
                            else if ((datith.positionX == atanth.positionX && datith.positionY == atanth.positionY && atanth.curHp > 0)
                                || (datith.positionX == princess.positionX && datith.positionY == princess.positionY))
                            {
                                datith.positionX += 2;
                            }
                            break;
                        case 'D':
                        case 'd':
                            datith.positionX += 2;
                            if (datith.positionX > windowWidth - 2 - 2)
                            {
                                datith.positionX = windowWidth - 2 - 2;
                            }
                            else if ((datith.positionX == atanth.positionX && datith.positionY == atanth.positionY && atanth.curHp > 0)
                                || (datith.positionX == princess.positionX && datith.positionY == princess.positionY))
                            {
                                datith.positionX -= 2;
                            }
                            break;
                        case 'F':
                        case 'f':
                            if ((((datith.positionY == atanth.positionY && (datith.positionX == atanth.positionX - 2 || datith.positionX == atanth.positionX + 2))
                                || (datith.positionX == atanth.positionX && (datith.positionY == atanth.positionY - 1 || datith.positionY == atanth.positionY + 1)))
                                && atanth.curHp > 0)
                                ||(((datith.positionY == princess.positionY && (datith.positionX == princess.positionX - 2 || datith.positionX == princess.positionX + 2))
                                || (datith.positionX == princess.positionX && (datith.positionY == princess.positionY - 1 || datith.positionY == princess.positionY + 1))))
                                )
                            {
                                if(atanth.curHp > 0)
                                {
                                    datith.isFight = true;
                                    atanth.isFight = true;
                                    Console.SetCursorPosition(2, windowHeight - 5);
                                    Console.ForegroundColor = myRed;
                                    Console.Write("进入战斗!,按<F>键继续.");
                                    Console.SetCursorPosition(2, windowHeight - 4);
                                    Console.ForegroundColor = myYellow;
                                    Console.Write($"<{datith.name}> 生命值:{datith.curHp}/{datith.maxHp} 攻击力:{datith.minAtk}-{datith.maxAtk} 防御力:{datith.def}");
                                    Console.SetCursorPosition(2, windowHeight - 3);
                                    Console.ForegroundColor = myGreen;
                                    Console.Write($"<{atanth.name}> 生命值:{atanth.curHp}/{atanth.maxHp} 攻击力:{atanth.minAtk}-{atanth.maxAtk} 闪避:{atanth.dodge}%");
                                    Console.ForegroundColor = myWhite;
                                }else
                                {
                                    Console.SetCursorPosition(2, windowHeight - 5);
                                    Console.Write("                                              ");
                                    Console.SetCursorPosition(2, windowHeight - 4);
                                    Console.Write("                                              ");
                                    Console.SetCursorPosition(2, windowHeight - 3);
                                    Console.Write("                                              ");
                                    Console.SetCursorPosition(2, windowHeight - 2);
                                    Console.Write("                                              ");
                                    Console.SetCursorPosition(2, windowHeight - 5);
                                    Console.ForegroundColor = myBlue;
                                    Console.Write($"营救公主<{princess.name}>成功!");
                                    gameResult = true;
                                    Console.ForegroundColor = myGreen;
                                    Console.SetCursorPosition(2, windowHeight - 4);
                                    Console.Write("按<任意键>结束");
                                    Console.ForegroundColor = myWhite;
                                    char iEt = Console.ReadKey(true).KeyChar;
                                    gameScene = 2;
                                    return;
                                }
                            }

                            break;
                        default:
                            break;
                    }
                    Console.ForegroundColor = myYellow;
                    Console.SetCursorPosition(datith.positionX, datith.positionY);
                    Console.Write(datith.icon);
                    Console.ForegroundColor = myWhite;
                } 
            }
            ;
        }
        static void GameEnd()
        {
            int opt = 0;
            Console.SetCursorPosition(windowWidth / 2 - 4, 5);
            Console.Write("GameOver");

            Console.SetCursorPosition(windowWidth / 2 - 4, 7);
            Console.Write(gameResult?"英雄救美":"惨遭屠杀");
            while (true)
            {
                Console.SetCursorPosition(windowWidth / 2 - 6, 10);
                Console.ForegroundColor = opt == 0 ? myRed : myWhite;
                Console.Write("回到开始界面");
                Console.ForegroundColor = opt == 1 ? myRed : myWhite;
                Console.SetCursorPosition(windowWidth / 2 - 4, 12);
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
                        if (opt == 0)
                        {
                            gameScene = 0;
                            return;
                        }
                        else if (opt == 1)
                        {
                            Environment.Exit(0);
                        }
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
