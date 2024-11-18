using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//游戏对象类

namespace 自个先写CSharp核心小项目_贪吃蛇_
{
    class GameObject : IPlan
    {
        Place place;

        //无参构造
        public GameObject()
        {

        }
        
        public GameObject(int x, int y)
        {
            place.x = x;
            place.y = y;
        }

        //实现绘制
        public virtual void Plan()
        {

        }
    }
}
