using Shop_Course.Data.Interfaces;
using Shop_Course.Models;
using System.Collections.Generic;

namespace Shop_Course.Data.Repository
{
    public class CategoryRepository : ICarsCategory
    {
        private readonly AppDBContent appDBContent;
        public CategoryRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public IEnumerable<Category> AllCategories => appDBContent.Categories;
    }
}
