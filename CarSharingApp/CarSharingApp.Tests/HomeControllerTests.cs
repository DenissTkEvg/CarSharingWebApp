using CarSharingApp.Controllers;
using CarSharingApp.DAL;
using CarSharingApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CarSharingApp.Tests
{
    public class HomeControllerTests
    {
        [Fact]
        public void Check_IndexIsViewResult_TrueReturned()
        {
            // Arrange
            var mock = new Mock<ILogger<HomeController>>();
            var controller = new HomeController(mock.Object);

            // Act
            var result = controller.Index();

            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Check_GetCarSearchIsJson_TrueReturned()
        {
            // Arrange
            var mock = new Mock<ILogger<HomeController>>();
            var controller = new HomeController(mock.Object);
            string carName = "Ferrari";
            int carsFreeFilter = 1;
            int carsPassengerFilter = 1;
            int automaticalTransmissionFilter = 1;
            int semiAutomaticalTransmissionFilter = 0;
            int mechanicalTransmissionFilter = 0;
            int priceForMinuteFrom = 3;
            int priceForMinuteTo = 9;


            // Act
            var result = controller.GetCarSearch(carName,carsFreeFilter,carsPassengerFilter,automaticalTransmissionFilter,semiAutomaticalTransmissionFilter,mechanicalTransmissionFilter,priceForMinuteFrom,priceForMinuteTo);

            // Assert
            var viewResult = Assert.IsType<JsonResult>(result);
            var model = Assert.IsAssignableFrom<string>(viewResult.Value);
        }
        [Fact]
        public void Check_ShowCarListIsViewResultWithCarsViewModel_TrueReturned()
        {
            // Arrange
            var mock = new Mock<ILogger<HomeController>>();
            var controller = new HomeController(mock.Object);

            // Act
            var result = controller.ShowCarList();

            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsAssignableFrom<CarsViewModel>(viewResult.Model);
        }
        [Fact]
        public void Check_ShowCarCardIsPartialViewResult_TrueReturned()
        {
            // Arrange
            var mock = new Mock<ILogger<HomeController>>();
            var controller = new HomeController(mock.Object);
            int carId = 4;
            // Act
            var result = controller.ShowCarCard(carId);

            // Assert
            var viewResult = Assert.IsType<PartialViewResult>(result);
        }
       
    }
}
