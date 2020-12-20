using System;
using System.Collections.Generic;
using System.Text;

namespace 超市收银系统__2
{
    class SuperMarket
    {
        CangKu ck = new CangKu();
        public SuperMarket()//当我们创建这个超市的时候，必须要有仓库，而且仓库里必须有货物
        {
            ck.JInPros("Acer", 1000);
            ck.JInPros("SamSung", 1000);
            ck.JInPros("JiangYou", 1000);
            ck.JInPros("Banana", 1000);
   
        }
        public void AsckBuying()
        {
            Console.WriteLine("欢迎！请问您需要什么？");
            Console.WriteLine("我们有Acer,SanSung,JiangYou,Banana");
            string strType = Console.ReadLine();
            Console.WriteLine("您需要多少？");
            int count = Convert.ToInt32(Console.ReadLine());
            //去仓库取货
            ProductFather[] pros = ck.QvPros(strType, count);
            //下面计算价钱
            double realMoney = GetMoney(pros);
            Console.WriteLine("您应该付{0}元",realMoney);
            Console.WriteLine("请选择您的打折方式：1--不打折 2--打九折 \n 3--打85折 4--卖500送100");
            string input = Console.ReadLine();
            CalFather cal = GetCal(input);
            double totalMoney = cal.GetTotailMoney(realMoney);
            Console.WriteLine("打折完您应付{0}元",totalMoney);
            foreach (var item in pros)
            {
                Console.WriteLine("货物名称:"+item.Name+","+"\t"+"货物单价"+item.Price+","+"\t"+"货物编码"+item.ID+"\t");
            }
        }
        /// <summary>
        /// 根据用户的打折方式返回一个对象，返回一个父类对象，但是里面装的是子类
        /// </summary>
        ///简单工厂设计模式 
        
        public CalFather GetCal(string input)
        {
            CalFather cal = null;
            switch(input)
            {
                case "1":cal = new CalNormal();
                    break;
                case "2":cal = new CalRate(0.9);
                    break;
                case "3": cal = new CalRate(0.85);
                    break;
                case "4":cal = new MaiSong(300, 50);
                    break;
                    
            }
            return cal;
        }
        public double GetMoney(ProductFather[] pros)
        {
            double realMoney = 0;
            for (int i = 0; i < pros.Length; i++)
            {
                realMoney += pros[i].Price;
            }
            return realMoney;
        }
        public void ShowPros()
        {
            ck.ShowPros();
        }



    }
}