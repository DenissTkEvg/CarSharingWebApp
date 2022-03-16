using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarSharingApp.Models
{
    public class DataBase
    {
        public DataBase()
        {
            using (var db = new LiteDatabase(@"CarShDataBase.db"))
            {
                var cars = db.GetCollection<Car>("cars");

                // Получаем все документы
                var result = cars.FindAll();
                // Индексируем документ по определенному свойству
                cars.EnsureIndex(x => x.CarName);

                Car car1 = new Car
                {
                    Id = 1,
                    CarImg = "vpolo1.jpg",
                    CarName = "Volkswagen Polo",
                    CarNumber = "432ВУ43",
                    Mileage = 5231,
                    PricePerMinute = 8,
                    Status = "Свободен",
                    IsFree = true,
                    Transmission = "АКПП",
                    Type = "Легковой автомобиль"
                };
                Car car2 = new Car
                {
                    Id = 2,
                    CarImg = "kiario2.jpg",
                    CarName = "Kia Rio",
                    CarNumber = "532ВК43",
                    Mileage = 4131,
                    PricePerMinute = 7,
                    Status = "Занят",
                    IsFree = false,
                    Transmission = "МКПП",
                    Type = "Легковой автомобиль"
                };
                Car car3 = new Car
                {
                    Id = 3,
                    CarImg = "hsolaris3.jpg",
                    CarName = "Hyundai Solaris",
                    CarNumber = "132БУ63",
                    Mileage = 6233,
                    PricePerMinute = 8,
                    Status = "Свободен",
                    IsFree = true,
                    Transmission = "АКПП",
                    Type = "Легковой автомобиль"
                };
                Car car4 = new Car
                {
                    Id = 4,
                    CarImg = "skodaoctavia4.jpg",
                    CarName = "Skoda Octavia",
                    CarNumber = "472ВЛ82",
                    Mileage = 9231,
                    PricePerMinute = 6,
                    Status = "Занят",
                    IsFree = false,
                    Transmission = "МКПП",
                    Type = "Легковой автомобиль"
                };
                Car car5 = new Car
                {
                    Id = 5,
                    CarImg = "ladavesta5.jpg",
                    CarName = "Lada Vesta",
                    CarNumber = "137ПГ52",
                    Mileage = 3257,
                    PricePerMinute = 8,
                    Status = "Занят",
                    IsFree = false,
                    Transmission = "АКПП",
                    Type = "Легковой автомобиль"
                };
                Car car6 = new Car
                {
                    Id = 6,
                    CarImg = "vpolo2.png",
                    CarName = "Volkswagen Polo",
                    CarNumber = "479ДЕ68",
                    Mileage = 3743,
                    PricePerMinute = 8,
                    Status = "Занят",
                    IsFree = false,
                    Transmission = "АКПП",
                    Type = "Легковой автомобиль"
                };
                Car car7 = new Car
                {
                    Id = 7,
                    CarImg = "kiario7.jpg",
                    CarName = "Kia Rio",
                    CarNumber = "125ВИ33",
                    Mileage = 1365,
                    PricePerMinute = 8,
                    Status = "Занят",
                    IsFree = false,
                    Transmission = "АКПП",
                    Type = "Легковой автомобиль"
                };
                Car car8 = new Car
                {
                    Id = 8,
                    CarImg = "hsolaris8.jpg",
                    CarName = "Hyundai Solaris",
                    CarNumber = "615ЖА49",
                    Mileage = 8366,
                    PricePerMinute = 7,
                    Status = "Свободен",
                    IsFree = true,
                    Transmission = "АКПП",
                    Type = "Легковой автомобиль"
                };
                Car car9 = new Car
                {
                    Id = 9,
                    CarImg = "skodaoctavia9.jpg",
                    CarName = "Skoda Octavia",
                    CarNumber = "631ЗЕ51",
                    Mileage = 4544,
                    PricePerMinute = 7,
                    Status = "Свободен",
                    IsFree = true,
                    Transmission = "МКПП",
                    Type = "Легковой автомобиль"
                };
                Car car10 = new Car
                {
                    Id = 10,
                    CarImg = "vpolo10.jpg",
                    CarName = "Volkswagen Polo",
                    CarNumber = "432ВУ43",
                    Mileage = 5231,
                    PricePerMinute = 8,
                    Status = "Свободен",
                    IsFree = true,
                    Transmission = "АКПП",
                    Type = "Легковой автомобиль"
                };
                Car car11 = new Car
                {
                    Id = 11,
                    CarImg = "fordtransit11.jpg",
                    CarName = "Ford Transit",
                    CarNumber = "431ПУ68",
                    Mileage = 6211,
                    PricePerMinute = 6,
                    Status = "Свободен",
                    IsFree = true,
                    Transmission = "МКПП",
                    Type = "Грузовой автомобиль"
                };
                Car car12 = new Car
                {
                    Id = 12,
                    CarImg = "fordtransit12.jpg",
                    CarName = "Ford Transit",
                    CarNumber = "231ПИ18",
                    Mileage = 4211,
                    PricePerMinute = 6,
                    Status = "Занят",
                    IsFree = false,
                    Transmission = "МКПП",
                    Type = "Грузовой автомобиль"
                };
                Car car13 = new Car
                {
                    Id = 13,
                    CarImg = "vpolo13.jpg",
                    CarName = "Volkswagen Polo",
                    CarNumber = "432ВУ43",
                    Mileage = 5231,
                    PricePerMinute = 8,
                    Status = "Свободен",
                    IsFree = true,
                    Transmission = "АКПП",
                    Type = "Легковой автомобиль"
                };
                Car car14 = new Car
                {
                    Id = 14,
                    CarImg = "vpolo14.jpg",
                    CarName = "Volkswagen Polo",
                    CarNumber = "436ЛУ23",
                    Mileage = 4231,
                    PricePerMinute = 7,
                    Status = "Свободен",
                    IsFree = true,
                    Transmission = "МКПП",
                    Type = "Легковой автомобиль"
                };
                Car car15 = new Car
                {
                    Id = 15,
                    CarImg = "kiario15.jpg",
                    CarName = "Kia Rio",
                    CarNumber = "144НЕ33",
                    Mileage = 7231,
                    PricePerMinute = 7,
                    Status = "Свободен",
                    IsFree = true,
                    Transmission = "АКПП",
                    Type = "Легковой автомобиль"
                };

                cars.Insert(car1);
                cars.Insert(car2);
                cars.Insert(car3);
                cars.Insert(car4);
                cars.Insert(car5);
                cars.Insert(car6);
                cars.Insert(car7);
                cars.Insert(car8);
                cars.Insert(car9);
                cars.Insert(car10);
                cars.Insert(car11);
                cars.Insert(car12);
                cars.Insert(car13);
                cars.Insert(car14);
                cars.Insert(car15);

                var result2 = cars.FindAll();
            }
        }


    }
}
