using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pie_backery.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategories =>
        new List<Category>{
        new Category{CategoryId=1,CategoryName="Fruit pies",Description="All-fruity pies" },
        new Category{CategoryId=2,CategoryName="Cheese cakes",Description="All-cheesey pies" },
        new Category{CategoryId=3,CategoryName="Seasonal Pies",Description="All-seasonal pies" }
        };
    }
}
