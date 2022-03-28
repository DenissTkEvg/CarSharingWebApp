using CarSharingApp.DAL;
using CarSharingApp.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CarSharingApp.Controllers
{
    public class AccountController:Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            LoginModel model = new LoginModel();
            return PartialView(model);
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                bool user_exist = AccountDAL.CheckUser(model.Login, model.Password); //проверка в БД введенных логина и пароля
                if (user_exist == true)
                {
                    await Authenticate(model.Login); // аутентификация

                    return RedirectToAction("Index", "Home");
                }
            }
            ErrorViewModel errorViewModel = new ErrorViewModel {
                ErrorMessage = "Некорректные логин и(или) пароль"
            };
            return View("~/Views/Shared/ErrorInfo.cshtml",errorViewModel);
        }

        [HttpGet]
        public IActionResult SignUp()
        {
            LoginModel model = new LoginModel();
            return PartialView(model);
        }
        [HttpPost]
        public IActionResult SignUp(LoginModel model)
        {
            try
            {
                AccountDAL.AddNewUser(model);
                TempData["Success"] = "Регистрация прошла успешно";
                return RedirectToAction("Index", "Home");
            }
            catch(Exception ex)
            {
                ErrorViewModel errorViewModel = new ErrorViewModel {
                    ErrorMessage = ex.Message
                };
                TempData["Error"] = "Ошибка при регистрации";
                return View("~/Views/Shared/ErrorInfo.cshtml",errorViewModel);
            }
        }
        [HttpGet]
        public IActionResult CheckAdminLogin(string login)
        {
            try
            {
                bool result = AccountDAL.CheckAdminLoginIsExist(login);
                string json = result.ToString();
                return Json(json);
            }
            catch (Exception ex)
            {
                ErrorViewModel errorViewModel = new ErrorViewModel
                {
                    ErrorMessage = ex.Message
                };
                return View("~/Views/Shared/ErrorInfo.cshtml", errorViewModel);
            }
        }
        private async Task Authenticate(string userName)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimsIdentity.DefaultNameClaimType, userName)
            };

            ClaimsIdentity id = new ClaimsIdentity(claims, "PhoneApplicationCookie", ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(id));
        }
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            foreach (var key in HttpContext.Request.Cookies.Keys)
            {
               HttpContext.Response.Cookies.Append(key, "", new CookieOptions() { Expires = DateTime.Now.AddDays(-1) });
            }
            return RedirectToAction("Index", "Home");
        }
    }
}
