using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MvcUsingModelValidations.Models;
using MvcUsingModelValidations.Repository;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MvcUsingModelValidations.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Country = new SelectList(new string[] { " ","India", "China", "US", "UK" });
            return View();
        }
        [HttpPost]
        public IActionResult Create(User item)
        {
            UserRepository repository = new UserRepository();
            repository.Add(item);
            return RedirectToAction("Login");
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string uname,string pwd)
        {
            UserRepository repository = new UserRepository();
            User user = repository.Validate(uname, pwd);
            if(user!=null)
            {
                return RedirectToAction("Details",user);
            }
            else
            {
                ViewData["err"] = "Invalid credientials";
                return View();
            }
        }
        public IActionResult Details(User item)
        {
            return View();
        }
        
    }
}