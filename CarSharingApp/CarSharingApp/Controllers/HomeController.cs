using CarSharingApp.DAL;
using CarSharingApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CarSharingApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GetCarSearch(string searchstr,int cars_free, int cars_passenger, int at,int pt,int mt,int pr_from, int pr_to)
        {
            try
            {
                List<Car> carList = CarDAL.SearchCarByName(searchstr, cars_free, cars_passenger, at, pt, mt, pr_from, pr_to);
                string json = Newtonsoft.Json.JsonConvert.SerializeObject(new
                {
                    carList
                });
                return Json(json);
            }
            catch(Exception ex)
            {
                ErrorViewModel errorViewModel = new ErrorViewModel
                {
                    ErrorMessage = ex.Message
                };
                return View("~/Views/Shared/ErrorInfo.cshtml", errorViewModel);
            }
        }
        public IActionResult ShowCarList()
        {
            try
            {
                CarsViewModel carsViewModel = new CarsViewModel()
                {
                    Cars = CarDAL.GetCars()
                };
                return View(carsViewModel);
            }
            catch(Exception ex)
            {
                ErrorViewModel errorViewModel = new ErrorViewModel
                {
                    ErrorMessage = ex.Message
                };
                return View("~/Views/Shared/ErrorInfo.cshtml", errorViewModel);
            }
        }
        public IActionResult ShowCarCard(int Id)
        {
            try
            {
                Car car = CarDAL.GetCarById(Id);
                return PartialView(car);
            }
            catch(Exception ex)
            {
                ErrorViewModel errorViewModel = new ErrorViewModel
                {
                    ErrorMessage = ex.Message
                };
                return View("~/Views/Shared/ErrorInfo.cshtml", errorViewModel);
            }
        }
        public IActionResult ShowCarSharingPoints()
        {
            return View();
        }
        public IActionResult ShowServiceInfo()
        {
            return View();
        }

      
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
