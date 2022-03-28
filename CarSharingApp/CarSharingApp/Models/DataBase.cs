using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CarSharingApp.Models
{
    public class DataBase
    {
        public DataBase()
        {
            using (var db = new LiteDatabase(@"CarShDataBase.db"))
            {
                //var cars = db.GetCollection<Car>("cars");

                //// Индексируем документ по определенному свойству
                //cars.EnsureIndex(x => x.CarName);

                //Car car1 = new Car
                //{
                //    Id = 1,
                //    CarImg = "vpolo1.jpg",
                //    CarName = "Volkswagen Polo",
                //    CarNumber = "432ВУ43",
                //    Mileage = 5231,
                //    PricePerMinute = 8,
                //    Status = "Свободен",
                //    IsFree = true,
                //    Transmission = "АКПП",
                //    Type = "Легковой автомобиль"
                //};
                //Car car2 = new Car
                //{
                //    Id = 2,
                //    CarImg = "kiario2.jpg",
                //    CarName = "Kia Rio",
                //    CarNumber = "532ВК43",
                //    Mileage = 4131,
                //    PricePerMinute = 7,
                //    Status = "Занят",
                //    IsFree = false,
                //    Transmission = "МКПП",
                //    Type = "Легковой автомобиль"
                //};
                //Car car3 = new Car
                //{
                //    Id = 3,
                //    CarImg = "hsolaris3.jpg",
                //    CarName = "Hyundai Solaris",
                //    CarNumber = "132БУ63",
                //    Mileage = 6233,
                //    PricePerMinute = 8,
                //    Status = "Свободен",
                //    IsFree = true,
                //    Transmission = "АКПП",
                //    Type = "Легковой автомобиль"
                //};
                //Car car4 = new Car
                //{
                //    Id = 4,
                //    CarImg = "skodaoctavia4.jpg",
                //    CarName = "Skoda Octavia",
                //    CarNumber = "472ВЛ82",
                //    Mileage = 9231,
                //    PricePerMinute = 6,
                //    Status = "Занят",
                //    IsFree = false,
                //    Transmission = "МКПП",
                //    Type = "Легковой автомобиль"
                //};
                //Car car5 = new Car
                //{
                //    Id = 5,
                //    CarImg = "ladavesta5.jpg",
                //    CarName = "Lada Vesta",
                //    CarNumber = "137ПГ52",
                //    Mileage = 3257,
                //    PricePerMinute = 8,
                //    Status = "Занят",
                //    IsFree = false,
                //    Transmission = "АКПП",
                //    Type = "Легковой автомобиль"
                //};
                //Car car6 = new Car
                //{
                //    Id = 6,
                //    CarImg = "vpolo2.png",
                //    CarName = "Volkswagen Polo",
                //    CarNumber = "479ДЕ68",
                //    Mileage = 3743,
                //    PricePerMinute = 8,
                //    Status = "Занят",
                //    IsFree = false,
                //    Transmission = "АКПП",
                //    Type = "Легковой автомобиль"
                //};
                //Car car7 = new Car
                //{
                //    Id = 7,
                //    CarImg = "kiario7.jpg",
                //    CarName = "Kia Rio",
                //    CarNumber = "125ВИ33",
                //    Mileage = 1365,
                //    PricePerMinute = 8,
                //    Status = "Занят",
                //    IsFree = false,
                //    Transmission = "АКПП",
                //    Type = "Легковой автомобиль"
                //};
                //Car car8 = new Car
                //{
                //    Id = 8,
                //    CarImg = "hsolaris8.jpg",
                //    CarName = "Hyundai Solaris",
                //    CarNumber = "615ЖА49",
                //    Mileage = 8366,
                //    PricePerMinute = 7,
                //    Status = "Свободен",
                //    IsFree = true,
                //    Transmission = "АКПП",
                //    Type = "Легковой автомобиль"
                //};
                //Car car9 = new Car
                //{
                //    Id = 9,
                //    CarImg = "skodaoctavia9.jpg",
                //    CarName = "Skoda Octavia",
                //    CarNumber = "631ЗЕ51",
                //    Mileage = 4544,
                //    PricePerMinute = 7,
                //    Status = "Свободен",
                //    IsFree = true,
                //    Transmission = "МКПП",
                //    Type = "Легковой автомобиль"
                //};
                //Car car10 = new Car
                //{
                //    Id = 10,
                //    CarImg = "vpolo10.jpg",
                //    CarName = "Volkswagen Polo",
                //    CarNumber = "432ВУ43",
                //    Mileage = 5231,
                //    PricePerMinute = 8,
                //    Status = "Свободен",
                //    IsFree = true,
                //    Transmission = "АКПП",
                //    Type = "Легковой автомобиль"
                //};
                //Car car11 = new Car
                //{
                //    Id = 11,
                //    CarImg = "fordtransit11.jpg",
                //    CarName = "Ford Transit",
                //    CarNumber = "431ПУ68",
                //    Mileage = 6211,
                //    PricePerMinute = 6,
                //    Status = "Свободен",
                //    IsFree = true,
                //    Transmission = "МКПП",
                //    Type = "Грузовой автомобиль"
                //};
                //Car car12 = new Car
                //{
                //    Id = 12,
                //    CarImg = "fordtransit12.jpg",
                //    CarName = "Ford Transit",
                //    CarNumber = "231ПИ18",
                //    Mileage = 4211,
                //    PricePerMinute = 6,
                //    Status = "Занят",
                //    IsFree = false,
                //    Transmission = "МКПП",
                //    Type = "Грузовой автомобиль"
                //};
                //Car car13 = new Car
                //{
                //    Id = 13,
                //    CarImg = "vpolo13.jpg",
                //    CarName = "Volkswagen Polo",
                //    CarNumber = "432ВУ43",
                //    Mileage = 5231,
                //    PricePerMinute = 8,
                //    Status = "Свободен",
                //    IsFree = true,
                //    Transmission = "АКПП",
                //    Type = "Легковой автомобиль"
                //};
                //Car car14 = new Car
                //{
                //    Id = 14,
                //    CarImg = "vpolo14.jpg",
                //    CarName = "Volkswagen Polo",
                //    CarNumber = "436ЛУ23",
                //    Mileage = 4231,
                //    PricePerMinute = 7,
                //    Status = "Свободен",
                //    IsFree = true,
                //    Transmission = "МКПП",
                //    Type = "Легковой автомобиль"
                //};
                //Car car15 = new Car
                //{
                //    Id = 15,
                //    CarImg = "kiario15.jpg",
                //    CarName = "Kia Rio",
                //    CarNumber = "144НЕ33",
                //    Mileage = 7231,
                //    PricePerMinute = 7,
                //    Status = "Свободен",
                //    IsFree = true,
                //    Transmission = "АКПП",
                //    Type = "Легковой автомобиль"
                //};

                //cars.Insert(car1);
                //cars.Insert(car2);
                //cars.Insert(car3);
                //cars.Insert(car4);
                //cars.Insert(car5);
                //cars.Insert(car6);
                //cars.Insert(car7);
                //cars.Insert(car8);
                //cars.Insert(car9);
                //cars.Insert(car10);
                //cars.Insert(car11);
                //cars.Insert(car12);
                //cars.Insert(car13);
                //cars.Insert(car14);
                //cars.Insert(car15);

                //var sharingPoints = db.GetCollection<SharingPoint>("car_sharing_points");

                //SharingPoint sharingPoint1 = new SharingPoint() {
                //    Id=1,
                //    Address="Россия, г. Москва, Пролетарский проспект, д.13Б"
                //};
                //SharingPoint sharingPoint2 = new SharingPoint()
                //{
                //    Id = 2,
                //    Address = "Россия, г. Москва, ул. Райгеля, д.3"
                //};

                //sharingPoints.EnsureIndex(x => x.Id);

                //sharingPoints.Insert(sharingPoint1);
                //sharingPoints.Insert(sharingPoint2);

                //var sharingHistory = db.GetCollection<CarSharingHistory>("car_sharing_history");

                //CarSharingHistory carSharingHistory = new CarSharingHistory() {
                //    Id = 1,
                //    SharingPointId = 1,
                //    UserId = 1,
                //    ChoosenCarId = 1,
                //    FinalPrice = 1160,
                //    MinutesCount = 8,
                //    SharingDate = DateTime.Parse("10.02.2022")
                //};

                //sharingHistory.EnsureIndex(x=>x.Id);

                //sharingHistory.Insert(carSharingHistory);

                //var users = db.GetCollection<User>("users");

                //string user1_pass = "123";
                //string user2_pass = "A123a";

                //byte[] user1_encodedPassword = new UTF8Encoding().GetBytes(user1_pass);
                //byte[] user1_hash = ((HashAlgorithm)CryptoConfig.CreateFromName("MD5")).ComputeHash(user1_encodedPassword);
                //string user1_hash_pass = Convert.ToBase64String(user1_hash);

                //byte[] user2_encodedPassword = new UTF8Encoding().GetBytes(user2_pass);
                //byte[] user2_hash = ((HashAlgorithm)CryptoConfig.CreateFromName("MD5")).ComputeHash(user2_encodedPassword);
                //string user2_hash_pass = Convert.ToBase64String(user2_hash);

                //User user1 = new User()
                //{
                //    Id = 1,
                //    Full_name = "Иванов Дмитрий Сергеевич",
                //    Email = "user1@gmail.com",
                //    IsAdmin = 0,
                //    Login = "user1@gmail.com",
                //    Password = user1_hash_pass,
                //    PhoneNumber = "+7913432345"
                //};
                //User user2 = new User()
                //{
                //    Id = 2,
                //    Full_name = "Титов Андрей Михайлович",
                //    Email = "user2@gmail.com",
                //    IsAdmin = 1,
                //    Login = "user2@gmail.com",
                //    Password = user2_hash_pass,
                //    PhoneNumber = "+7913432115"
                //};
                //users.EnsureIndex(x => x.Email);

                //users.Insert(user1);
                //users.Insert(user2);


                //var sh = sharingPoints.FindAll().ToList();
                //var h = sharingHistory.FindAll().ToList();
                //var u = users.FindAll().ToList();
            }
        }


    }
}
