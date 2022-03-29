using Microsoft.AspNetCore.Mvc;
using Shop_Course.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop_Course.Controllers
{
    public class CarsController : Controller
    {
        private readonly IAllCars _allCars;
        private readonly ICarsCategory _allCarsCategories;

        public CarsController(IAllCars iAllCars, ICarsCategory iCarsCat)
        {
            _allCars = iAllCars;
            _allCarsCategories = iCarsCat;
        }
        public ViewResult List()
        {
            var cars = _allCars.cars;
            return View(cars);
        }
    }
}
