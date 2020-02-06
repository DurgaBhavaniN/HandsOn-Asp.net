using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DemoCookieSession.Models;

namespace DemoCookieSession.Controllers
{
    //
    [Route("[controller]/[action]")]
    public class CookieSessionController : Controller
    {
        public readonly UserAccountContext _context;
        public CookieSessionController(UserAccountContext context)
        {
            this._context = context;
        }
        [Route("")]
        

        // GET: CookieSession
        [HttpGet]
        public ActionResult RegisterUser()
        {
            return View();
        }
        [HttpPost]
        public ActionResult RegisterUser(UserAccount uc)
        {
            try
            {
                _context.Add(uc);
                _context.SaveChanges();
                ViewBag.message = uc.UserName + " Has got successfully Registered";
                return View("Login");
            }
            catch(Exception e)
            {
                ViewBag.message = uc.UserName + " Registration Failed";
                return View();
            }  
        }
        [HttpGet]
        [Route("CookieSession")]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        
        public ActionResult Login(UserAccount uc)
        {
            var logUser = _context.UserAccounts.Where(e => e.UserName == uc.UserName && e.Password == uc.Password).ToList();
            if (logUser.Count == 0)
            {
                ViewBag.message = "Not valid user";
                return View();
            }
            else
            {
                HttpContext.Session.SetString("UName", uc.UserName);
                
                //HttpContext.Session.SetString("lastLogin", DateTime.Now.ToString());
                return RedirectToAction("CreateDashBoard");
            }
        }
        public ActionResult CreateDashBoard()
        {
            if (HttpContext.Session.GetString("UName") != null)
            {
                ViewBag.uname = HttpContext.Session.GetString("UName").ToString();
                //ViewBag.lldt = HttpContext.Session.GetString("lastLogin").ToString();
               if(Request.Cookies["lastLogin"]!=null)
                ViewBag.lldt = Request.Cookies["lastLogin"].ToString();
            }
            return View();
        }
        public ActionResult LogOut()
        {
            Response.Cookies.Append("lastLogin", DateTime.Now.ToString());
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }
        //public ActionResult Index()
        //{
        //    return View();
        //}
        // GET: CookieSession/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CookieSession/Create
       

        // POST: CookieSession/Create
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

        // GET: CookieSession/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CookieSession/Edit/5
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

        // GET: CookieSession/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CookieSession/Delete/5
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