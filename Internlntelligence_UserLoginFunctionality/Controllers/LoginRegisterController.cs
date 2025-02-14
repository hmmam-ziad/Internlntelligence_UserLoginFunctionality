using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Internlntelligence_UserLoginFunctionality.Controllers
{
    public class LoginRegisterController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;

        public LoginRegisterController(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
        }
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        public IActionResult Welcome()
        {
            if(!User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Login");
            }
            
            return View();
        }
    }
}
