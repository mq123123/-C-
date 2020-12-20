
using System;
using System.Collections.Generic;
using System.Text;

namespace 超市收银系统__2
{
    abstract class CalFather
    {/// <summary>
     /// 计算打折后应该付多少钱
     /// </summary>
        public abstract double GetTotailMoney(double realMoney);

    }
}
