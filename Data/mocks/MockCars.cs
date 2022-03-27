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
                            img = "https://avtodream.org/uploads/posts/2020-10/1602591785_tesla-ponizil-stoimost-model-s.jpg",
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
                        img = "https://www.avtorinok.ru/photo/pics/ford/fiesta/104881.jpg",
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
                        img = "https://a.d-cd.net/44a5a19s-960.jpg",
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
                        img = "https://carakoom.com/data/wall/787/64ce8273.jpg",
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
                        img = "https://www.carscoops.com/wp-content/uploads/2021/02/2022-Mercedes-Benz-C-Class-10-2.jpg",
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
                        img = "https://www.avtorinok.ru/photo/pics/ford/fiesta/104881.jpg",
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
