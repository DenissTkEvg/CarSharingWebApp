using CarSharingApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
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
        //[HttpPost]
        //public async Task<IActionResult> Login(LoginModel model)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        //bool user_exist = AccountDal.CheckUser(model.Login, model.Password); //проверка в БД введенных логина и пароля
        //        //if (user_exist == true)
        //        //{
        //        //    await Authenticate(model.Login); // аутентификация

        //        //    return RedirectToAction("IndexAdmin", "Admin");
        //        //}
        //    }
        //    model.ErrorMessage = "Некорректные логин и(или) пароль";
        //    return PartialView(model);
        //}
    }
}
