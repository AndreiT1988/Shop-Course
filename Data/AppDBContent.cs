using Microsoft.EntityFrameworkCore;
using Shop_Course.Models;
//using System.Data.Entity;
namespace Shop_Course.Data
{
    public class AppDBContent : DbContext
    {
        public AppDBContent(DbContextOptions<AppDBContent> options) : base(options)
        {

        }
        public DbSet<Car> Car { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
