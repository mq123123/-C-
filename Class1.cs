using System;
using System.Collections.Generic;
using System.Text;

namespace 超市收银系统__2
{
    /// <summary>
    /// 按折扣率打折
    /// </summary>
    class CalRate:CalFather
    {
        public double Rate
        {
            get;
            set;

        }
        public CalRate(double rate)
        {
            this.Rate = rate;
        }
        public override double GetTotailMoney(double realMoney)
        {
            return (Rate * realMoney);
        }
    
    
    
    }
}
