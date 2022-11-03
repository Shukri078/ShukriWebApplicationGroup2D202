using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Principal;
using System;
using System.Threading.Tasks;

namespace ShukriWebApplication.Controllers
{
    public class ResetPassword : Controller
    {
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly UserManager<IdentityUser> userManager;

        public ResetPassword(RoleManager<IdentityRole> roleManager,
                               UserManager<IdentityUser> userManager)
        {
            this.roleManager = roleManager;
            this.userManager = userManager;
        }
        //RESEEEEEEEEEEEEEEEEEEEEEEEEEEEEET PASSSSSSSSSSSSSWOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOORD
        [HttpGet]
        public IActionResult ResetUsersPassword()
        {
            var users = userManager.Users;
            return View(users);
        }








        //RESET
        [HttpPost]
        public async Task<IActionResult> DeleteUser(string id)
        {
            var user = await userManager.FindByIdAsync(id);

            if (user == null)
            {
                ViewBag.ErrorMessage = $"User with Id = {id} cannot be found";
                return View("NotFound");
            }
            else
            {
                var result = await userManager.DeleteAsync(user);
                if (result.Succeeded)
                {
                    return RedirectToAction("ResetPasswordTokenIdGenerateDzashdhasjashjdgaas", "Account");
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }

                return View("~/Views/Account/ResetPasswordTokenIdGenerateDzashdhasjashjdgaas.cshtml");
            }
        }


















    }
}
