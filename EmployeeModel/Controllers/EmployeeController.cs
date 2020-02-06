using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeModel.Models;
using EmployeeModel.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

 namespace EmployeeModel.Controllers
{
    public class EmployeeController:Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string eid,string pwd)
        {
            EmployeeRepository repository = new EmployeeRepository();
            Employee employee = repository.Validate(eid, pwd);
            if(employee!=null)
            {
                return RedirectToAction("Details", employee);
            }
            else
            {
                ViewData["err"] = "Invalid Credientials";
                //return RedirectToAction("Signup", employee); 
                return View();
            }

        }
        public IActionResult Details([Bind (include:"Name")]Employee item)
        {
            return View(item);
        }
        
        public IActionResult Signup()
        {
            ViewBag.Degination = new SelectList(new string[] { "Worker", "Manager", "Employee", "Accountant" });
            ViewBag.P_Name = new SelectList(new string[] { "EmployeeManagement", "OnlineFormRequest", "OnlinePemissionSystem" });
            return View();
        }
        [HttpPost]
        public IActionResult Signup(Employee item)
        {
            EmployeeRepository repository = new EmployeeRepository();
            repository.Add(item);
            return RedirectToAction("Login");
        }
    }
}
