using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Practical_6.Models;


namespace Practical_6.Controllers
{
    public class productController : Controller
    {
        // GET: product
        public ActionResult Index()
        {
            products p1 = new products();
            p1.product_ID = 1;
            p1.product_Name ="Samsung";
            p1.product_Desc = "8GB RAM 256GB Storage";
            p1.product_Category = "Mobile";
            p1.product_price = 580000;

            
            return View(p1);
        }
    }
}