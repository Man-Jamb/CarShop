using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Data.Interfaces;
using WebApplication1.Data.Models;

namespace WebApplication1.Data.Mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory _categoryCars = new MockCategory();

        public IEnumerable<Car> Cars 
        {
            get
            {
                return new List<Car>
                {
                    new Car 
                    { 
                        name = "tesla",
                        shortDesc = "",
                        longDesc = "",
                        img = "/img/tesla.jpg",
                        price = 45000,
                        isFavoured = true,
                        availiable = true,
                        Category = _categoryCars.AllCategories.First()
                    },
                    new Car 
                    { 
                        name = "bmv",
                        shortDesc = "",
                        longDesc = "",
                        img = "/img/bmw.jpg",
                        price = 25000,
                        isFavoured = false,
                        availiable = true,
                        Category = _categoryCars.AllCategories.Last()
                    }
                };
            }
        }
        public IEnumerable<Car> GetFavCars { get ; set ; }

        public Car GetObjectCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
