using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//开始场景

namespace 自个先写CSharp核心小项目_贪吃蛇_
{
    class Begin : BeginAndFinish
    {
        public Begin()
        {
            str = "贪吃蛇";
            str1 = "开始游戏";
            str2 = "结束游戏";
        }

        //重写更新方法
        public override void newers()
        {
            Console.SetCursorPosition(48, 10);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(str);
            Console.SetCursorPosition(47, 13);
            Console.ForegroundColor = key == 1 ? ConsoleColor.Red : ConsoleColor.White;
            Console.WriteLine(str1);
            Console.SetCursorPosition(47, 15);
            Console.ForegroundColor = key == 2 ? ConsoleColor.Red : ConsoleColor.White;
            Console.WriteLine(str2);

            char c = Console.ReadKey(true).KeyChar;
            switch (c)
            {
                case 'W':
                case 'w':
                    key = 1;
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
