using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//蛇类

namespace 自个先写CSharp核心小项目_贪吃蛇_
{
    //移动方向枚举
    enum E_Move
    {
        Up,
        Down,
        Left,
        Right,
    }

    class Snake
    {
        string snakeHead = "●";
        string snakeBody = "◎";
        int x = 10;
        int y = 5;
        E_Move move = E_Move.Down;
        char c;
        Foods foods = new Foods();
        int bodyNum = 0;
        //标识符
        int[] num1 = new int[10000];
        int[] num2 = new int[10000];
        //打印出长度
        public string longs = "当前长度为:";

        //蛇绘制
        public void SnakePlan()
        {
            //打印长度
            Console.SetCursorPosition(2, 1);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(longs + bodyNum);

            Finish.num = bodyNum;

            //蛇头的绘制
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(snakeHead);

            //蛇身的绘制
            for (int i = 0; i < bodyNum; i++)
            {
                Console.SetCursorPosition(num1[i], num2[i]);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(snakeBody);
            }
        }

        //蛇清除
        public void SnakeClear()
        {
            //打印长度清除
            Console.SetCursorPosition(2, 1);
            Console.WriteLine("               ");
            //蛇头的清除
            Console.SetCursorPosition(x, y);
            Console.WriteLine("  ");

            //蛇身的清除
            for (int i = 0; i < bodyNum; i++)
            {
                Console.SetCursorPosition(num1[i], num2[i]);
                Console.WriteLine("  ");
            }
        }

        //蛇转向
        public void SnakeTurn()
        {
            //老师漏讲的知识点，Console.KeyAvailable -- 检测键盘是否被激活
            if (Console.KeyAvailable == true)
            {
                c = Console.ReadKey(true).KeyChar;
                switch (c)
                {
                    case 'W':
                    case 'w':
                        if (move == E_Move.Down && bodyNum != 0)
                        {
                            move = E_Move.Down;
                        }
                        else
                        {
                            move = E_Move.Up;
                        }
                        break;
                    case 'S':
                    case 's':
                        if (move == E_Move.Up && bodyNum != 0)
                        {
                            move = E_Move.Up;
                        }
                        else
                        {
                            move = E_Move.Down;
                        }
                        break;
                    case 'A':
                    case 'a':
                        if (move == E_Move.Right && bodyNum != 0)
                        {
                            move = E_Move.Right;
                        }
                        else
                        {
                            move = E_Move.Left;
                        }
                        break;
                    case 'D':
                    case 'd':
                        if (move == E_Move.Left && bodyNum != 0)
                        {
                            move = E_Move.Left;
                        }
                        else
                        {
                            move = E_Move.Right;
                        }
                        break;
                    default:
                        break;
                }
            }
            
        } 

        //吃食物

        //死亡

        


        //蛇移动 -- (包含了蛇绘制、蛇转向、吃食物）
        public void SnakeMove()
        {
            if(foods.x == 0 || foods.y == 0)
            {
                foods.Plan();
            }
            SnakeTurn();
            switch (move)
            {
                case E_Move.Up:
                    SnakeClear();
                    y -= 1;
                    //判断是否死亡
                    //撞墙死亡
                    if (y == 0)
                    {
                        Game.scene = E_Scene.FinishID;
                        GameScene.bo = false;
                        break;
                    }
                    //撞身体死亡
                    for (int i = 0; i < bodyNum; i++)
                    {
                        if(num1[i] == x && num2[i] == y)
                        {
                            Game.scene = E_Scene.FinishID;
                            GameScene.bo = false;
                            break;
                        }
                    }

                    if (foods.x == x && foods.y == y)
                    {
                        foods.Plan();
                        //给个判断，让生成的food不会出现在有蛇身体的位置上
                        for (int i = 0; i < bodyNum; i++)
                        {
                            if (foods.x == num1[i] && foods.y == num2[i] && (foods.y == 1 && foods.x < 12))
                            {
                                Console.SetCursorPosition(foods.x, foods.y);
                                Console.WriteLine("  ");
                                foods.Plan();
                                i = 0;
                            }
                        }

                        bodyNum += 1;
                        for (int i = bodyNum - 1; i > 0; i--)
                        {
                            num1[i] = num1[i - 1];
                            num2[i] = num2[i - 1];
                        }
                        num1[0] = x;
                        num2[0] = y + 1;
                    }
                    else
                    {
                        for (int i = bodyNum - 1; i > 0; i--)
                        {
                            num1[i] = num1[i - 1];
                            num2[i] = num2[i - 1];
                        }
                        num1[0] = x;
                        num2[0] = y + 1;
                    }
                    SnakePlan();
                    
                    break;
                case E_Move.Down:
                    SnakeClear();
                    y += 1;
                    //判断是否死亡
                    //撞墙死亡
                    if (y == 29)
                    {
                        Game.scene = E_Scene.FinishID;
                        GameScene.bo = false;
                        break;
                    }
                    //撞身体死亡
                    for (int i = 0; i < bodyNum; i++)
                    {
                        if (num1[i] == x && num2[i] == y)
                        {
                            Game.scene = E_Scene.FinishID;
                            GameScene.bo = false;
                            break;
                        }
                    }

                    if (foods.x == x && foods.y == y)
                    {
                        foods.Plan();
                        //给个判断，让生成的food不会出现在有蛇身体的位置上
                        for (int i = 0; i < bodyNum; i++)
                        {
                            if (foods.x == num1[i] && foods.y == num2[i] && (foods.y == 1 && foods.x < 12))
                            {
                                Console.SetCursorPosition(foods.x, foods.y);
                                Console.WriteLine("  ");
                                foods.Plan();
                                i = 0;
                            }
                        }

                        bodyNum += 1;
                        for (int i = bodyNum - 1; i > 0; i--)
                        {
                            num1[i] = num1[i - 1];
                            num2[i] = num2[i - 1];
                        }
                        num1[0] = x;
                        num2[0] = y - 1;
                    }
                    else
                    {
                        for (int i = bodyNum - 1; i > 0; i--)
                        {
                            num1[i] = num1[i - 1];
                            num2[i] = num2[i - 1];
                        }
                        num1[0] = x;
                        num2[0] = y - 1;
                    }
                    SnakePlan();
                    break;
                case E_Move.Left:
                    SnakeClear();
                    x -= 2;
                    //判断是否死亡
                    //撞墙死亡
                    if (x == 0)
                    {
                        Game.scene = E_Scene.FinishID;
                        GameScene.bo = false;
                        break;
                    }
                    //撞身体死亡
                    for (int i = 0; i < bodyNum; i++)
                    {
                        if (num1[i] == x && num2[i] == y)
                        {
                            Game.scene = E_Scene.FinishID;
                            GameScene.bo = false;
                            break;
                        }
                    }

                    if (foods.x == x && foods.y == y)
                    {
                        foods.Plan();
                        //给个判断，让生成的food不会出现在有蛇身体的位置上
                        for (int i = 0; i < bodyNum; i++)
                        {
                            if (foods.x == num1[i] && foods.y == num2[i] && (foods.y == 1 && foods.x < 12))
                            {
                                Console.SetCursorPosition(foods.x, foods.y);
                                Console.WriteLine("  ");
                                foods.Plan();
                                i = 0;
                            }
                        }

                        bodyNum += 1;
                        for (int i = bodyNum - 1; i > 0; i--)
                        {
                            num1[i] = num1[i - 1];
                            num2[i] = num2[i - 1];
                        }
                        num1[0] = x + 2;
                        num2[0] = y;
                    }
                    else
                    {
                        for (int i = bodyNum - 1; i > 0; i--)
                        {
                            num1[i] = num1[i - 1];
                            num2[i] = num2[i - 1];
                        }
                        num1[0] = x + 2;
                        num2[0] = y;
                    }
                    SnakePlan();
                    break;
                case E_Move.Right:
                    SnakeClear();
                    x += 2;
                    //判断是否死亡
                    //撞墙死亡
                    if (x == 98)
                    {
                        Game.scene = E_Scene.FinishID;
                        GameScene.bo = false;
                        break;
                    }
                    //撞身体死亡
                    for (int i = 0; i < bodyNum; i++)
                    {
                        if (num1[i] == x && num2[i] == y)
                        {
                            Game.scene = E_Scene.FinishID;
                            GameScene.bo = false;
                            break;
                        }
                    }

                    if (foods.x == x && foods.y == y)
                    {
                        foods.Plan();
                        //给个判断，让生成的food不会出现在有蛇身体的位置上
                        for (int i = 0; i < bodyNum; i++)
                        {
                            if (foods.x == num1[i] && foods.y == num2[i] && (foods.y == 1 && foods.x < 12))
                            {
                                Console.SetCursorPosition(foods.x, foods.y);
                                Console.WriteLine("  ");
                                foods.Plan();
                                i = 0;
                            }
                        }

                        bodyNum += 1;
                        for (int i = bodyNum - 1; i > 0; i--)
                        {
                            num1[i] = num1[i - 1];
                            num2[i] = num2[i - 1];
                        }
                        num1[0] = x - 2;
                        num2[0] = y;
                    }
                    else
                    {
                        for (int i = bodyNum - 1; i > 0; i--)
                        {
                            num1[i] = num1[i - 1];
                            num2[i] = num2[i - 1];
                        }
                        num1[0] = x - 2;
                        num2[0] = y;
                    }
                    SnakePlan();
                    break;
                default:
                    break;
            }
        }

    }
}
