using ASM1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static ASM1.Models.Products;

namespace ASM1.Controllers
{
    
    public class ASMController : Controller
    {
        private QLBGiayContext db = new QLBGiayContext();

        private readonly QLBGiayContext _context;

        public ASMController(QLBGiayContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            ProductModels productModel = new ProductModels();
            ViewBag.products = productModel.FindAll();

            ViewBag.UsersName = HttpContext.Session.GetString("UsersName");
            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            ViewBag.UsersName = HttpContext.Session.GetString("UsersName");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(string usersName, string passWord)
        {
            //var x = Request.Form["usersName"];
            if (ModelState.IsValid)
            {
                var data = _context.Users.Where(s => s.UsersName.Equals(usersName) && s.UsersPassword.Equals(passWord)).ToList();

                if (data.Count() > 0)
                {
                    HttpContext.Session.SetString("UsersName",usersName);
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    ViewBag.error = "Users & Mật Khẩu Không Đúng";
                    return View();
                }
            }
            return View();                  
        }

        public ActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }

        
        public IActionResult Cart()
        {
            decimal a = 30000;
            var cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            ViewBag.cart = cart;
            ViewBag.total = cart.Sum(item => item.Products.ProductPrice * item.ProductAmount);
            ViewBag.total1 = cart.Sum(item => (item.Products.ProductPrice * item.ProductAmount) + a);
            ViewBag.UsersName = HttpContext.Session.GetString("UsersName");
            return View();
        }

        public IActionResult ProductCard()
        {
            return View();
        }

        private int isExist(int id)
        {
            List<Item> cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            for (int i = 0; i < cart.Count; i++)
            {
                if (cart[i].Products.ProductId.Equals(id))
                {
                    return i;
                }
            }
            return -1;
        }

        public IActionResult Buy(int id)
        {
            ProductModels productModel = new ProductModels();
            if (SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart") == null)
            {
                List<Item> cart = new List<Item>();
                cart.Add(new Item { Products = productModel.Find(id), ProductAmount = 1 });
                SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            }
            else
            {
                List<Item> cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
                int index = isExist(id);
                if (index != -1)
                {
                    cart[index].ProductAmount++;
                }
                else
                {
                    cart.Add(new Item { Products = productModel.Find(id), ProductAmount = 1 });
                }
                SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            }
            return RedirectToAction("Cart");
        }

        public IActionResult Remove(int id)
        {
            List<Item> cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            int index = isExist(id);
            cart.RemoveAt(index);
            SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            return RedirectToAction("Cart");
        }


    }
}
