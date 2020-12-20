using System;
using System.Collections.Generic;
using System.Text;

namespace 超市收银系统__2
{
    class CalNormal:CalFather
    {
        public override double GetTotailMoney(double realMoney)
        {
            return realMoney;
        }
    }
}
