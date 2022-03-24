using Shop_Course.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop_Course.Data.Interfaces
{
    interface ICarsCategory
    {
        IEnumerable<Category> AllCategories { get; set; }
    }
}
