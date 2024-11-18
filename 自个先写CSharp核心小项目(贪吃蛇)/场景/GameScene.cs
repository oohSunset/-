using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//游戏场景类

namespace 自个先写CSharp核心小项目_贪吃蛇_
{
    class GameScene : INewer
    {
        Map map = new Map();
        SnakeBody snakeBody = new SnakeBody();
        public static bool bo = true;

        public void newers()
        {
            //地图绘制
            map.Plan();
            //食物绘制
            //food.Plan();
            //蛇绘制
            while (bo)
            {
                //蛇绘制
                snakeBody.Plan();
                //因为正常帧率太快，所以我加了个循环让帧率慢点
                for (int i = 0; i < 100000000; i++)
                {
                    if(i == 88888888)
                    {
                        break;
                    }
                }
            }
            bo = true;
            
        }

    }
}
