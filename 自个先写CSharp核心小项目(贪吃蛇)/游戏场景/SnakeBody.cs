using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//蛇身体类

namespace 自个先写CSharp核心小项目_贪吃蛇_
{
    //身体类型枚举
    enum E_SnakeBody
    {
        head,
        body,
    }

    class SnakeBody : GameObject
    {
        E_SnakeBody snakeHead = new E_SnakeBody();
        E_SnakeBody snakeBody = new E_SnakeBody();
        Snake snake = new Snake();

        public SnakeBody()
        {
            snakeHead = E_SnakeBody.head;
            snakeBody = E_SnakeBody.body;
        }

        //绘制
        public override void Plan()
        {
            snake.SnakeMove();
        }

    }
}
