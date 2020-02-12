using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pie_backery.Models
{
    public class MockPieRepository : IPieRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();
       

        public IEnumerable<Pie> AllPies =>
            new List<Pie>
            {
                new Pie{ PieId=1,Name="Strawberry Pie", Price=15.95M, ShortDescription="Lorem Ipsum", LongDescription="Long long description",Category=_categoryRepository.AllCategories.ToList()[0],ImageUrl="https://media.istockphoto.com/photos/whole-cherry-pie-picture-id535475493?k=6&m=535475493&s=612x612&w=0&h=yyG800xq7-noeZMUuCcSvieN_Pq7k_hY6y7AbISmz-s=",Instock=true,IsPieOfTheWeek=true,ImageThumbnailUrl="https://media.istockphoto.com/photos/whole-cherry-pie-picture-id535475493?k=6&m=535475493&s=612x612&w=0&h=yyG800xq7-noeZMUuCcSvieN_Pq7k_hY6y7AbISmz-s="},
                new Pie{ PieId=2,Name="Cheese Cake", Price=10.95M, ShortDescription="Lorem Ipsum", LongDescription="Long long description",Category=_categoryRepository.AllCategories.ToList()[1],ImageUrl="https://www.landolakes.com/RecipeManagementSystem/media/Recipe-Media-Files/Recipes/Retail/x17/16800-blue-ribbon-apple-pie-600x600.jpg?ext=.jpg",Instock=true,IsPieOfTheWeek=false,ImageThumbnailUrl="https://www.landolakes.com/RecipeManagementSystem/media/Recipe-Media-Files/Recipes/Retail/x17/16800-blue-ribbon-apple-pie-600x600.jpg?ext=.jpg"},
                new Pie{ PieId=3,Name="Rhubarb Pie", Price=11.95M, ShortDescription="Lorem Ipsum", LongDescription="Long long description",Category=_categoryRepository.AllCategories.ToList()[0],ImageUrl="https://ichef.bbci.co.uk/food/ic/food_16x9_832/recipes/chicken_pie_24044_16x9.jpg",Instock=false,IsPieOfTheWeek=true,ImageThumbnailUrl="https://ichef.bbci.co.uk/food/ic/food_16x9_832/recipes/chicken_pie_24044_16x9.jpg"},
                new Pie{ PieId=4,Name="Pumpkin Pie", Price=12.95M, ShortDescription="Lorem Ipsum", LongDescription="Long long description",Category=_categoryRepository.AllCategories.ToList()[2],ImageUrl="https://food.fnr.sndimg.com/content/dam/images/food/fullset/2009/6/15/0/JI_20731_s4x3.jpg.rend.hgtvcom.826.620.suffix/1371589402748.jpeg",Instock=true,IsPieOfTheWeek=false,ImageThumbnailUrl="https://food.fnr.sndimg.com/content/dam/images/food/fullset/2009/6/15/0/JI_20731_s4x3.jpg.rend.hgtvcom.826.620.suffix/1371589402748.jpeg"}
            };

        public IEnumerable<Pie> PiesOfTheWeek { get; }

        public Pie GetPieById(int pieId)
        {
            return AllPies.FirstOrDefault(p => p.PieId == pieId);
        }

        //object IPieRepository.GetPieById(int id)
        //{
        //        return AllPies.FirstOrDefault(p => p.PieId == id);
            
        //}
    }
}
