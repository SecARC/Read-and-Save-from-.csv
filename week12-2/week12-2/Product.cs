using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week12_2
{
    public class Product
    {
        public int id { get; set; }
        public string title { get; set; }
        public double  price { get; set; }
        public int catid { get; set; }
    }

    public class Category
    {
        public int id { get; set; }
        public string title { get; set; }
    }
}
