namespace randomCreate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Random r = new Random();
            ////生成一个随机正数 值大
            //int n = r.Next();
            ////生成一个0到99的随机数
            //n = r.Next(100);
            ////生成一个90到99的随机数
            //n = r.Next(90, 100);
            //for (int i = 0; i < 10; i++)
            //{
            //    n = r.Next(0, 10);
            //    Console.WriteLine(n);
            //}

            #region 1.打怪兽
            Random r1 = new Random();
            
            int monsterDef = 10;
            int monsterHel = 20;
            int dmg = 0;
            while(monsterHel > 0)
            {
                int tangAtk = r1.Next(8, 13);
                if(tangAtk > monsterDef)
                {
                    dmg = tangAtk - monsterDef;
                }
                else
                {
                    dmg = 0;
                }
                monsterHel -= dmg;
                Console.WriteLine($"唐的攻击力为:{tangAtk},怪兽防御力为:10,唐对怪兽造成了{dmg}点伤害值,怪兽的生命值剩余:{monsterHel}");
            }
            #endregion
        }
    }
}
