using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//位置结构体

namespace 自个先写CSharp核心小项目_贪吃蛇_
{
    struct Place
    {
        public int x;
        public int y;

        public Place(int x,int y)
        {
            this.x = x;
            this.y = y;
        }

        public static Boolean operator ==(Place p1, Place p2)
        {
            if(p1.x == p2.x && p1.y == p2.y)
            {
                return true;
            }
            return false;
        }

        public static Boolean operator !=(Place p1, Place p2)
        {
            if (p1.x != p2.x && p1.y != p2.y)
            {
                return true;
            }
            return false;
        }

    }
}
