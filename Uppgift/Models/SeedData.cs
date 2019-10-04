using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new UppgiftContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<UppgiftContext>>()))
            {
                // Look for any movies.
                if (context.Article.Any())
                {
                    return;   // DB has been seeded
                }

                /*public int Id { get; set; }
        public string Name { get; set; }
        public string ArticleNum { get; set; }
        public string Description { get; set; }
        public Category Category { get; set; }
        public int Price { get; set; }
        public int PriceVAT { get; set; }*/

        context.Article.AddRange(
                    new Article
                    {
                        ArticleNum = "39533028",
                        Name = "Elcykel Allegro",
                        Description = "En smart och tillförlitlig elcykel för dam från Batavus utmärkt både för långa och kortareturer.",
                        Category = "Sport",
                        Price = 16186.625,
                        //PriceVAT = 18499
                    },

                    new Article
                    {
                        ArticleNum = "40266837",
                        Name = "Lapierre Overvolt Urban 300",
                        Description = "Praktisk och bekväm elcykel med upprätt körställning.",
                        Category = "Sport" ,
                        Price = 18366.25,
                        //PriceVAT = 20990
                    },

                    new Article
                    {
                        ArticleNum = "p35372817",
                        Name = "Chrome cast 2nd generationen",
                        Description = "Visar film eller annan media från mobilen på TV:n",
                        Category = "Hemelektronik",
                        Price = 341.25,
                        //PriceVAT = 390
                    },

                    new Article
                    {
                        ArticleNum = "35552289",
                        Name = "Apple TV 64GB 4th generation",
                        Description = "Nu kommer App Store till din tv. Du kan förvänta dig massor av spännande spel.",
                        Category = "Hemelektronik",
                        Price = 1741.25,
                        //PriceVAT = 1990
                    },
                    new Article
                    {
                        ArticleNum = "40151785",
                        Name = "Big Foot truck 2wd",
                        Description = "Det här är bilen som startade alltihop och skapade den idag enorma monster - truck trenden.",
                        Category = "Leksaker",
                        Price = 2445.625,
                        //PriceVAT = 2795
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
