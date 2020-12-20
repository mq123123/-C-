using System;
using System.Collections.Generic;
using System.Text;

namespace 超市收银系统__2
{
    class MaiSong:CalFather
    {
        //买500送100
        public double m
        {
            get;
            set;
        }
        public double n
        {
            get;
            set;
                
        }
        public MaiSong(double m,double s)
        {
            this.m = m;
            this.n = n; 
        }
        public override double GetTotailMoney(double realMoney)
        {
           if(realMoney >= this.m)
            {
                return realMoney - (realMoney / this.m) * this.n;
            }
            else
            {
                return realMoney;
            }
        }
    }
}
