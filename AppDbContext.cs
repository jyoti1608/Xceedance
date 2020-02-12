using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace pie_backery.Models
{
    public class AppDbContext : DbContext {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Pie> Pies { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            base OnModelCreating(modelbuilder);

            modelbuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "Fruit pies" });
            modelbuilder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "Cheese Cake" });
            modelbuilder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "Seasonal Pies" });


            modelbuilder.Entity<Pie>().HasData(new Pie)
                {
                PieId = 1;
                Name ="Apple Pie",
                Price = 12.95M,
                ShortDescription = "fgvdf bhgh jhg",
                LongDescription= "Long long description",CategoryId=1,
                ImageUrl = "https://food.fnr.sndimg.com/content/dam/images/food/fullset/2009/6/15/0/JI_20731_s4x3.jpg.rend.hgtvcom.826.620.suffix/1371589402748.jpeg",
                Instock = true,
                IsPieOfTheWeek = false,
                ImageThumbnailUrl = "https://food.fnr.sndimg.com/content/dam/images/food/fullset/2009/6/15/0/JI_20731_s4x3.jpg.rend.hgtvcom.826.620.suffix/1371589402748.jpeg"
                });
            modelbuilder.Entity<Pie>().HasData(new Pie)
                {
                PieId = 2;
                Name = "Apple Pie",
                Price = 12.95M,
                ShortDescription = "fgvdf bhgh jhg",
                LongDescription = "Long long description",
                CategoryId = 2,
                ImageUrl = "https://food.fnr.sndimg.com/content/dam/images/food/fullset/2009/6/15/0/JI_20731_s4x3.jpg.rend.hgtvcom.826.620.suffix/1371589402748.jpeg",
                Instock = true,
                IsPieOfTheWeek = false,
                ImageThumbnailUrl = "https://food.fnr.sndimg.com/content/dam/images/food/fullset/2009/6/15/0/JI_20731_s4x3.jpg.rend.hgtvcom.826.620.suffix/1371589402748.jpeg"
                });

        }
    }
        //protected override void OnModelCreating(ModelBuilder builder)
        //{
        //    base.OnModelCreating(builder);
        //    builder.Entity<Pie>()
        //        .HasOne(p => p.RecipeInformation)
        //        .WithOne(i => i.Pie)
        //        .HasForeignKey<RecipeInformation>(b => b.PieId);

        //    builder.Entity<ApplicationUser>()
        //        .HasMany(e => e.Claims)
        //        .WithOne()
        //        .HasForeignKey(e => e.UserId)
        //        .IsRequired()
        //        .OnDelete(DeleteBehavior.Cascade);
        //}


        //public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        //public DbSet<Order> Orders { get; set; }
        //public DbSet<OrderDetail> OrderDetails { get; set; }
        //public DbSet<PieReview> PieReviews { get; set; }
        //public DbSet<PieGiftOrder> PieGiftOrders { get; set; }

    }
}

