using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//结束场景

namespace 自个先写CSharp核心小项目_贪吃蛇_
{
    class Finish : BeginAndFinish
    {
        string str0;
        public static int num;

        public Finish()
        {
            key = 0;
            str = "游戏结束";
            str0 = "本次游戏的长度为:";
            str1 = "回到开始界面";
            str2 = "结束游戏";
        }

        //重写更新方法
        public override void newers()
        {
            Console.SetCursorPosition(47, 10);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(str);
            Console.SetCursorPosition(42, 12);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(str0 + num);
            Console.SetCursorPosition(45, 15);
            Console.ForegroundColor = key == 0 ? ConsoleColor.Red : ConsoleColor.White;
            Console.WriteLine(str1);
            Console.SetCursorPosition(47, 17);
            Console.ForegroundColor = key == 2 ? ConsoleColor.Red : ConsoleColor.White;
            Console.WriteLine(str2);

            char c = Console.ReadKey(true).KeyChar;
            switch (c)
            {
                case 'W':
                case 'w':
                    key = 0;
                    break;
                case 'S':
                case 's':
                    key = 2;
                    break;
                case 'J':
                case 'j':
                    if (key == 2)
                    {
                        //关闭控制台
                        Environment.Exit(0);
                    }
                    Game.scene = (E_Scene)key;
                    break;
                default:
                    break;
            }
        }

    }
}
