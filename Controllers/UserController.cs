
using logindemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace logindemo.Controllers
{
    public class UserController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            vmLogin model = new vmLogin();
            return View(model);
        }
        [HttpPost]
        public IActionResult Login(vmLogin model)
        {
            if(!ModelState.IsValid)
                return View(model);
            var login = new vmLogin();
            var user = login.UserList.Where(m=>m.UserNo == model.UserNo&& m.Password == model.Password) .FirstOrDefault();
            if(user == null)
            {
                ModelState.AddModelError("UserNo","輸入帳號或密碼不正確!");
                return View(model);
            }
            return RedirectToAction("Index","Home",new {area = ""});
        }
    }
}