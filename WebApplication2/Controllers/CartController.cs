using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class CartController : Controller
    {
        // GET: Cart
        public ActionResult Index(string id)
        {
            if (!User.Identity.IsAuthenticated)
            {   
                Session["cart"] = null;
                return RedirectToAction("Login", "Account");
            }
            else {
                productLogicModel productModel = new productLogicModel();
                if (Session["cart"] == null)
                {
                    List<item> cart = new List<item>();
                    cart.Add(new item { Product = productModel.find(id), Quantity = 1 });
                    Session["cart"] = cart;
                }
                return View();
            }
        }
        public ActionResult Checkout()
        {
            Session["cart"] = null;
            return View();
        }

        // GET: Cart/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        public ActionResult Buy(string id)
        {
            productLogicModel productModel = new productLogicModel();
            if (Session["cart"] == null)
            {
                List<item> cart = new List<item>();
                cart.Add(new item { Product = productModel.find(id), Quantity = 1 });
                Session["cart"] = cart;
            }
            else
            {
                List<item> cart = (List < item >) Session["cart"];
                int index = exists(id);
                if (index != -1)
                {
                    cart[index].Quantity++;
                }
                else
                {
                    cart.Add(new item { Product = productModel.find(id), Quantity = 1 });
                }
                Session["cart"] = cart;
            }
            return RedirectToAction("Index");
        }


        private int exists(string id)
        {
            List<item> cart = (List<item>)Session["cart"];
            for (int i = 0; i < cart.Count; i++)
                if (cart[i].Product.PRODUCT_CODE.Equals(id))
                    return i;
            return -1;
        }
      

      public ActionResult Delete(string id)
        {
            List<item> cart = (List<item>)Session["cart"];
            int index = exists(id);
            cart.RemoveAt(index);
            Session["cart"] = cart;
            return RedirectToAction("Index");
        }

       

        

       
        
    }
}
