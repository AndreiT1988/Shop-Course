using Shop_Course.Data.Interfaces;
using Shop_Course.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop_Course.Data.mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory _categoryCars = new MockCategory();
        public IEnumerable<Car> Cars
        {
            get
            {
                return new List<Car> {
                    {
                        new Car { name = "Tesla",
                            shortDesc = "Быстрый автомобиль",
                            longDesc = "Красивый и тихий автомобмль для городской жизни",
                            img = "/img/tesla.jpg",
                            price = 45000,
                            isFavourite = true,
                            available = true,
                            Category = _categoryCars.AllCategories.First() }
                    },
                    new Car
                    {
                        name = "Ford Fiesta",
                        shortDesc = "Тихий и спокойный",
                        longDesc = "Удобный автомобиль для городской жизни",
                        img = "/img/ford fiesta.jpg",
                        price = 11000,
                        isFavourite = true,
                        available = true,
                        Category = _categoryCars.AllCategories.Last()
                    },
                    new Car
                    {
                        name = "WV Luppo",
                        shortDesc = "Тихий и спокойный",
                        longDesc = "Удобный автомобиль для городской жизни",
                        img = "/img/WV luppo.jpg",
                        price = 12000,
                        isFavourite = true,
                        available = true,
                        Category = _categoryCars.AllCategories.Last()
                    },
                    new Car
                    {
                        name = "BMW M3",
                        shortDesc = "Дерзкий и стильный",
                        longDesc = "Удобный автомобиль для городской жизни",
                        img = "/img/BMW M3.jpg",
                        price = 65000,
                        isFavourite = true,
                        available = true,
                        Category = _categoryCars.AllCategories.Last()
                    },
                    new Car
                    {
                        name = "Mercedes C Class",
                        shortDesc = "Быстрый автомобиль",
                        longDesc = "Удобный автомобиль для городской жизни",
                        img = "/img/Mercedes-Benz-C-Class.jpg",
                        price = 48000,
                        isFavourite = true,
                        available = true,
                        Category = _categoryCars.AllCategories.Last()
                    },
                    new Car
                    {
                        name = "Nisan Leaf",
                        shortDesc = "Тихий и спокойный",
                        longDesc = "Удобный автомобиль для городской жизни",
                        img = "/img/nissan_leaf.jpg",
                        price = 14000,
                        isFavourite = true,
                        available = true,
                        Category = _categoryCars.AllCategories.First()
                    },
                    
                };   
            }
        }

        public IEnumerable<Car> cars { get; set; }
        public IEnumerable<Car> getFavCars { get ; set; }

        public Car getObjectCar(int carId)
        {
            throw new NotImplementedException();
        }
    }

}
