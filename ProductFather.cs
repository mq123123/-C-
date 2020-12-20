using System;
using System.Collections.Generic;
using System.Text;

namespace 超市收银系统__2
{
    class ProductFather
    {
        public double Price
        {
            get;
            set;
        }
        public string Name
        {
            get;
            set;
        }
        public string ID
        {
            get;
            set;
        }
    public ProductFather(string id,double price,string name)//父类构造函数
        {
            this.ID = id;
            this.Name = name;
            this.Price = price;
        }
    
    }
}
