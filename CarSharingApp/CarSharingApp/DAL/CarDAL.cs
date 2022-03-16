using CarSharingApp.Models;
using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarSharingApp.DAL
{
    public static class CarDAL
    {
        public static List<Car> GetCars()
        {
            List<Car> car_list = new List<Car>();
            using (var db = new LiteDatabase(@"CarShDataBase.db"))
            {
                var cars = db.GetCollection<Car>("cars");
                car_list = cars.FindAll().ToList();
            }
            return car_list;
        }
        public static List<Car> SearchCarByName(string str, int cars_free_filter, int cars_passenger_filter,int at, int pt, int mt, int price_from, int price_to)
        {
            List<Car> search_results = new List<Car>();
            using (var db = new LiteDatabase(@"CarShDataBase.db"))
            {
                var cars = db.GetCollection<Car>("cars");
                if (cars_free_filter == 0)
                {
                    search_results = cars.FindAll().Where(c => c.CarName.ToUpper().Contains(str.ToUpper()) == true).ToList();
                }
                else
                {
                    search_results = cars.FindAll().Where(c => c.CarName.ToUpper().Contains(str.ToUpper()) == true && c.IsFree == true).ToList();
                }
                if (cars_passenger_filter == 1)
                {
                    search_results = search_results.Where(c => c.Type == "Легковой автомобиль").ToList();
                }
                if (at != 0 || pt != 0 || mt != 0)
                {
                    search_results = getResultsWithTransmitionFilter(search_results, at, pt, mt);
                }
                if (price_from != -1)
                {
                    search_results = search_results.Where(c => c.PricePerMinute >= price_from).ToList();
                }
                if (price_to != -1)
                {
                    search_results = search_results.Where(c => c.PricePerMinute <= price_to).ToList();
                }
            }
            return search_results;

        }
        public static Car GetCarById(int id)
        {
            Car result = new Car();
            using (var db = new LiteDatabase(@"CarShDataBase.db"))
            {
                var cars = db.GetCollection<Car>("cars");
                result = cars.FindAll().FirstOrDefault(c=>c.Id==id);
            }
            return result;
        }
        private static List<Car> getResultsWithTransmitionFilter(List<Car> search_results, int at,int pt, int mt)
        {
            List<Car> t_search_results = new List<Car>();
            if (at == 1)
            {
                var at_cars = search_results.Where(c => c.Transmission== "АКПП");
                if (at_cars!=null)
                {
                    t_search_results.AddRange(at_cars);
                }
            }
            if (pt == 1)
            {
                var pt_cars = search_results.Where(c => c.Transmission == "ПКПП");
                if (pt_cars!=null)
                {
                    t_search_results.AddRange(pt_cars);
                }
            }
            if (mt == 1)
            {
                var mt_cars = search_results.Where(c => c.Transmission=="МКПП");
                if (mt_cars!=null)
                {
                    t_search_results.AddRange(mt_cars);
                }
            }
            var test = t_search_results;
            return t_search_results;
        }
    }
}
