using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//游戏类

namespace 自个先写CSharp核心小项目_贪吃蛇_
{
    enum E_Scene
    {
        BeginID,
        GamingID,
        FinishID,
    }

    class Game
    {
        public static int x;
        public static int y;
        public static E_Scene scene = new E_Scene();
        Begin begin = new Begin();
        Finish finish = new Finish();

        public Game()
        {
            x = 100;
            y = 30;
            scene = E_Scene.BeginID;
        }

        //初始化控制台
        public void Consoles()
        {
            //隐藏光标
            Console.CursorVisible = false;
            //设置舞台大小
            Console.SetWindowSize(x, y);
            Console.SetBufferSize(x, y);

        }

        //游戏主循环
        public void MajorCycle()
        {
            while (true)
            {
                //思考一下，为什么把开始场景和结束场景的类申明放在外面，而游戏场景的类申明放循环里面
                //因为开始结束场景是一成不变的，只需申明一次就够用了
                //而游戏场景进入一次就会执行出结果出来，每次结果都将不一样，所以每次都得重新申明
                switch (scene)
                {
                    case E_Scene.BeginID:
                        Console.Clear();
                        begin.newers();
                        break;
                    case E_Scene.GamingID:
                        Console.Clear();
                        GameScene gameScene = new GameScene();
                        gameScene.newers();
                        break;
                    case E_Scene.FinishID:
                        Console.Clear();
                        finish.newers();
                        break;
                    default:
                        break;
                }
            }
        }

        //场景切换
        public void SceneMove()
        {

        }

    }
}
