using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Emart.Model;
using Microsoft.AspNetCore.Mvc;
using System.Web;
using Emart.Controllers;

namespace Emart.Controllers
{
    public class EmartController:Controller
    {
        //IsellerBo sellerbo = new SellerBo();
        private readonly IsellerBo sellerbo;
        public EmartController(IsellerBo sebo)
        {
            sellerbo = sebo;
        }
        public IActionResult Search(int? id)
        {
            int s_id = (int)((id == null) ? 1 : id);
            Seller s = sellerbo.Search_Id(s_id);
            //return s.s_id + "\n" + s.s_name + "\n" + s.s_pwd + "\n" + s.s_emailid + "\n" + s.postal_address + "\n" + s.gstin + "\n" + s.bank_details;
            return View(s);
        }
        public IActionResult Index()
        {
            List<Seller> se = sellerbo.DisplayDetails();
            return View(se);
        }
        public IActionResult GetAllSellers()
        {
            List<Seller> se = (sellerbo.DisplayDetails()).Where(e => e.postal_address == "chirala").ToList();
            return View("Index",se);
        }
    }
}
