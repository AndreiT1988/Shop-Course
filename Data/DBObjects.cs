using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Shop_Course.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop_Course.Data
{
    public class DBObjects
    {
        public static void Initial(AppDBContent content)
        {
            
            if (!content.Categories.Any())
                content.Categories.AddRange(Categories.Select(c => c.Value));

            if (!content.Car.Any())
            {
                content.AddRange(
                    new Car
                    {
                        name = "Tesla",
                        shortDesc = "Быстрый автомобиль",
                        longDesc = "Красивый и тихий автомобмль для городской жизни",
                        img = "/img/tesla.jpg",
                        price = 45000,
                        isFavourite = true,
                        available = true,
                        Category = Categories["Электромобмлм"]
                    
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
                        Category = Categories["Классические автомобмлм"]
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
                        Category = Categories["Классические автомобмлм"]
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
                        Category = Categories["Классические автомобмлм"]
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
                        Category = Categories["Классические автомобмлм"]
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
                        Category = Categories["Электромобмлм"]
                    }
                    );
            }
            content.SaveChanges();
        }

        private static Dictionary<string, Category> category;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if(category == null)
                {
                    var list = new Category[]
                    {
                        new Category { categoryName = "Электромобмлм", desc ="Современный вид транспорта" },
                        new Category { categoryName = "Классические автомобмлм", desc = "Машины с ДВС"}
                    };

                    category = new Dictionary<string, Category>();
                    foreach (Category el in list)
                        category.Add(el.categoryName, el);
                }
                return category;
            }

        }
    }
}
