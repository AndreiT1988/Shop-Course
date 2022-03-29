using Microsoft.AspNetCore.Mvc;
using Shop_Course.Data.Interfaces;
using Shop_Course.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shop_Course.ViewModels;

namespace Shop_Course.Controllers
{
    public class CarsController : Controller
    {
        private readonly IAllCars _allCars;
        private readonly ICarsCategory _allCategories;

        public CarsController(IAllCars iAllCars, ICarsCategory iCarsCat)
        {
            _allCars = iAllCars;
            _allCategories = iCarsCat;
        }
        public ViewResult List()
        {
            ViewBag.Title = "Страница с автомобилями";
            CarsListViewModel obj = new CarsListViewModel();
            obj.allCars = _allCars.Cars;
            obj.carrCAtegory ="Автомобили";
            //var cars = _allCars.Cars;
            return View(obj);
        }
    }
}
