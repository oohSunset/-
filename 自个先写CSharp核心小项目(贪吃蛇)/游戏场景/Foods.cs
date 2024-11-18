using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//食物类

namespace 自个先写CSharp核心小项目_贪吃蛇_
{
    class Foods : GameObject
    {
        public int x;
        public int y;

        public override void Plan()
        {
            Random r = new Random();
            x = r.Next(2, 97);
            if (x % 2 != 0)
            {
                x += 1;
            }
            y = r.Next(1, 29);
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("¤");
        }

    }
}
