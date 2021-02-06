using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using WebApplication1.Data.Models;

namespace WebApplication1.Data
{
    public class DBObjects
    {
        public static void Initial(AppDBContent content)
        {
            if (!content.Category.Any())
                content.Category.AddRange(Categories.Select(c => c.Value));
            if (!content.Car.Any())
                content.AddRange(
                    new Car
                    {
                        name = "tesla",
                        shortDesc = "",
                        longDesc = "",
                        img = "/img/tesla.jpg",
                        price = 45000,
                        isFavoured = true,
                        availiable = true,
                        Category = Categories["Электромобили"]
                    },
                    new Car
                    {
                        name = "bmv",
                        shortDesc = "",
                        longDesc = "",
                        img = "/img/bmw.jpg",
                        price = 25000,
                        isFavoured = false,
                        availiable = true,
                        Category = Categories["Класика"]
                    }
                    );

            content.SaveChanges();
        }

        private static Dictionary<string, Category> category;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if(category == null)
                {
                    var list = new Category[]
                    {
                        new Category { categoryName = "Электромобили", desc = "На электричестве" },
                        new Category { categoryName = "Класика", desc = "На бензине" }
                    };

                    category = new Dictionary<string, Category>();
                    foreach (Category el in list)
                        category.Add(el.categoryName, el);
                }

                return category;
            }
        }
    }
}
