using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//地图墙壁类

namespace 自个先写CSharp核心小项目_贪吃蛇_
{
    class Map : GameObject
    {
        //绘制墙壁
        public override void Plan()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            //横墙
            for (int i = 0; i < Game.x - 2; i += 2)
            {
                Console.SetCursorPosition(i, 0);
                Console.Write("■");

                Console.SetCursorPosition(i, Game.y - 1);
                Console.Write("■");
            }

            //竖墙
            for (int i = 0; i < Game.y - 1; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write("■");

                Console.SetCursorPosition(Game.x - 2, i);
                Console.Write("■");
            }
        }
    }
}
