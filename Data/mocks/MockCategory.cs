using Shop_Course.Data.Interfaces;

using Shop_Course.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop_Course.Data.mocks
{
    public class MockCategory : ICarsCategory { 
    
        public IEnumerable<Category> AllCategories {

            get {

                return new List<Category>
                {
                    new Category{categoryName = "Электромобмлм", desc ="Современный вид транспорта" },
                    new Category{categoryName = "Классические автомобмлм", desc = "Машины с ДВС"}
                };
            }
        }

    }
}
