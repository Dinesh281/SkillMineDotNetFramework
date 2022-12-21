using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillMineDotNetFramework.OOPS
{
    class Book
    {
        int id;
        string name;
        string author;
        int price;
        
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Author { get => author; set => author = value; }
        public int Price { get => price; set => price = value; }
        public override string ToString()
        {
            return $"{id},{name},{author},{price}";
        }


    }
}
