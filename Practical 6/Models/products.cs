using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practical_6.Models
{
    public class products
    {
        public int product_ID { get; set; }
        public string product_Name { get; set; }
        
        public string product_Desc { get; set; }

        public decimal product_price { get; set; }

        public string product_Category { get; set; }

    }
}