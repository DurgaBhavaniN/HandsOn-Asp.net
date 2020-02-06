using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using EmartProject.Models;

namespace EmartProject.Controllers
{
    public class EmartController : Controller
    {
        public readonly SellerContext _context;
        public readonly BuyerContext _context1;
        public readonly ProductContext _context2;
        public EmartController(SellerContext context,BuyerContext context1,ProductContext context2)
        {
            _context = context;
               _context1= context1;
            _context2 = context2;
        }
        [HttpGet]
        public ActionResult S_SignUp()
        {
            return View();
        }
        [HttpPost]
        public ActionResult S_SignUp(Seller s)
        {
            try
            {
                _context.Add(s);
                _context.SaveChanges();
                ViewBag.message = s.s_name + " Has got successfully Registered";
                return View();
            }
            catch (Exception e)
            {
                ViewBag.message = s.s_name + " Registration Failed";
                return View();
            }
        }
        [HttpGet]
        public ActionResult B_SignUp()
        {
            return View();
        }
        [HttpPost]
        public ActionResult B_SignUp(Buyer b)
        {
            try
            {
                _context1.Add(b);
                _context1.SaveChanges();
                ViewBag.message = b.b_name + " Has got successfully Registered";
                return View();
            }
            catch (Exception e)
            {
                ViewBag.message = b.b_name + " Registration Failed";
                return View();
            }
        }
        [HttpGet]
        public ActionResult S_Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult S_Login(Seller s)
        {
            var logUser = _context.Sellers.Where(e => e.s_id ==s.s_id && e.s_pwd == s.s_pwd).ToList();
            if (logUser.Count == 0)
            {
                ViewBag.message = "InValid Credientials";
                return View();
            }
            else
            {
                //HttpContext.Session.SetInt32("SID", s.s_id);
                ViewBag.message = "Login Successfull";
                return RedirectToAction("SellerDashBoard");
            }
        }
        [HttpGet]
        public ActionResult B_Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult B_Login(Buyer s)
        {
            var logUser = _context1.Buyers.Where(e => e.b_id == s.b_id && e.b_pwd == s.b_pwd).ToList();
            if (logUser.Count == 0)
            {
                ViewBag.message = "InValid Credientials";
                return View();
            }
            else
            {
                HttpContext.Session.SetInt32("SName", s.b_id);
                return RedirectToAction("BuyerDashBoard");
            }
        }

        // GET: Emart
        public ActionResult S_Index()
        {
            return View();
        }
        public ActionResult B_Index()
        {
            return View();
        }
        public ActionResult SellerDashBoard()
        {
            return View();
        }
        [HttpGet]
        public ActionResult AddItems()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddItems(Product p)
        {
            try
            {
                _context2.Add(p);
                _context2.SaveChanges();
                ViewBag.message = p.i_name + " has added successfully";
                return View();
            }
            catch (Exception e)
            {
                ViewBag.message = p.i_name + " Adding Failed";
                return View();
            }
            
        }

        // GET: Emart/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Emart/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Emart/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Emart/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Emart/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Emart/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Emart/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}