using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillMineDotNetFramework.Collection.Generic_Collection
{
  
    public class Product
    {
        public string Prdname { get; set; }
        public string Colour { get; set; }
        public int Price { get; set; }

    }
    public class Category
    {
        public string prdtype;
        public List<Product> prod = new List<Product>();
    }
    class Listing
    {
        /*static void Main(string[] args)
        {
            List<Category> clist = new List<Category>()
            {
                new Category
                {
                    prdtype="Furniture",
                    prod={new Product {Prdname="Chair",Colour="Black",Price=500},
                          new Product {Prdname="Sofa",Colour="Blue",Price=10000},
                          new Product {Prdname="Dining Table",Colour="Grey",Price=1000}
                    }
                },
                new Category
                {
                    prdtype="Mobile",
                    prod={new Product {Prdname="Samsung",Colour="Carbon Black",Price=10500},
                          new Product {Prdname="Nokia",Colour="Blue",Price=10000},
                          new Product {Prdname="One Plus",Colour="Grey",Price=40000}
                    }
                },
                new Category
                {
                    prdtype="Cloth",
                    prod={new Product {Prdname="Shirt",Colour="Blue",Price=1500},
                          new Product {Prdname="Pant",Colour="Black",Price=2000},
                          new Product {Prdname="Tshirt",Colour="Grey",Price=1000}
                    }
                }
            };
            foreach (Category c in clist)
            {
                Console.WriteLine($"Category--> {c.prdtype} ");
                foreach (Product p in c.prod)
                {
                    Console.WriteLine($"Product--> {p.Prdname} colour--> {p.Colour} Price--> {p.Price}");
                }
            }
        }*/
    }
}
