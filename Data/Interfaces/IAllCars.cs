using Shop_Course.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop_Course.Data.Interfaces
{
    public interface IAllCars
    {
        IEnumerable<Car> cars { get; set; }
        IEnumerable<Car> getFavCars { get; set; }
        Car getObjectCar(int carId);
    }
}
