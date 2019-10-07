using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BusinessLib.Model.Entity;
// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UKChinaTravel.Controllers.Folder
{
    public class LoginController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index(UserInfo user )
        {
            return View();
        }
        [HttpPost]
        public object Save(UserInfo user)
        {
            if (!ModelState.IsValid)
            {
                //Model has Error(s)  
                return View("Index", user);
            }
            return null;
        }
    }
}
