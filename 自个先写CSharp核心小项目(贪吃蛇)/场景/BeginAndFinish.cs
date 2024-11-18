using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//开始和结束场景基类

namespace 自个先写CSharp核心小项目_贪吃蛇_
{
    class BeginAndFinish : INewer
    {
        protected int key;
        protected string str;
        protected string str1;
        protected string str2;

        public BeginAndFinish()
        {
            key = 1;
        }

        //重写更新方法
        public virtual void newers()
        {

        }

    }
}
