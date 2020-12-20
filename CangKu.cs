using System;
using System.Collections.Generic;
using System.Text;

namespace 超市收银系统__2
{
    class CangKu
    {
        //存储货物
        List<List<ProductFather>> list = new List<List<ProductFather>>();
        //list[0]存储Acer电脑
        //List[1]存储三星手机
        //List[2]存储酱油
        //List[3]存储香蕉
        public CangKu()
        {
            list.Add(new List<ProductFather>());
            list.Add(new List<ProductFather>());
            list.Add(new List<ProductFather>());
            list.Add(new List<ProductFather>());
        }//我们现自添加的是货架
        /// <summary>
        /// 
        /// </summary>
        /// <param 货物名="strType"></param>
        /// <param 数量="count"></param>
        public  void JInPros(string strType, int count)
        {
            for(int i = 0;i<count;i++)
            {

           
            switch(strType)
            {
                    case "Acer":
                        list[0].Add(new Acer(Guid.NewGuid().ToString(), 1000, "鸿基笔记本"));
                    break;
                    case "SamSung":list[1].Add(new SamSung(Guid.NewGuid().ToString(), 5000, "三星手机"));
                        break;
                    case"JiangYou":list[2].Add(new JiangYou(Guid.NewGuid().ToString(), 10, "老抽酱油"));
                        break;
                    case "Banana":list[3].Add(new Banana(Guid.NewGuid().ToString(), 50, "大香蕉"));
                        break;
                
            }
        }
        
        }
        public ProductFather[] QvPros(string StrType, int count)
        {
            ProductFather[] pros = new ProductFather[count];
            for (int i = 0; i < count; i++)
            {
                switch (StrType)
                {
                    
                    case "Acer": pros[i] = list[0][0];
                        list[0].RemoveAt(0);//删除了第一个，第二个就顶上来成为第一个
                        break;
                    case "SamSung":pros[i] = list[1][0];
                        list[1].RemoveAt(0);
                        break;
                    case "JiangYou":pros[i] = list[2][0];
                        list[2].RemoveAt(0);
                        break;
                    case "Banana":pros[i] = list[3][0];
                        list[3].RemoveAt(0);
                        break;
                }   

            }
            return pros;
        }

       //向用户展示货物
       public void ShowPros()
        {
            foreach (var item in list)
            {
                Console.WriteLine("我们仓库有"+item[0].Name+"\t"+"有"+item.Count+"个"+"每个"+item[0].Price+"元"+"\t");
                
            }
        }
    }
}
